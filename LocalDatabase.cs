using System.Data.SQLite;

namespace Uetm_2_0
{
    public static class LocalDatabase
    {
        // изменить нижнию строку на: internal static readonly string DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.db"); чтобы сохранение БД было там же где и exe файл
        internal static readonly string DbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Uetm_2_0", "config.db");
        // %LocalAppData%\Uetm_2_0
        internal static readonly string ConnectionString = $"Data Source={DbPath};Version=3;";

        static LocalDatabase()
        {
            _ = Directory.CreateDirectory(Path.GetDirectoryName(DbPath) ?? "");

            using SQLiteConnection conn = new(ConnectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();

            // Таблицы
            cmd.CommandText = @"
        CREATE TABLE IF NOT EXISTS Passwords (
            Role TEXT PRIMARY KEY,
            Password TEXT NOT NULL
        );
        CREATE TABLE IF NOT EXISTS Devices (
            IP TEXT PRIMARY KEY,
            Port INTEGER NOT NULL,
            InstallationPlace TEXT,
            SwitchLabel TEXT
        );
        CREATE TABLE IF NOT EXISTS ChangeLog (
            Id INTEGER PRIMARY KEY,
            Timestamp TEXT NOT NULL,
            UserRole TEXT NOT NULL,
            Description TEXT NOT NULL,
            DeviceIP TEXT,
            CurrentA REAL,
            ResourcePercent REAL,
            Channel TEXT
        );";
            _ = cmd.ExecuteNonQuery();

            // Добавляем недостающие столбцы (если таблица ChangeLog уже существовала)
            AddColumnIfMissing(conn, "ChangeLog", "DeviceIP", "TEXT");
            AddColumnIfMissing(conn, "ChangeLog", "CurrentA", "REAL");
            AddColumnIfMissing(conn, "ChangeLog", "ResourcePercent", "REAL");
            AddColumnIfMissing(conn, "ChangeLog", "Channel", "TEXT");

            // Пароли по умолчанию
            cmd.CommandText = "SELECT COUNT(*) FROM Passwords";
            long cnt = (long)cmd.ExecuteScalar();
            if (cnt == 0)
            {
                cmd.CommandText = "INSERT INTO Passwords (Role, Password) VALUES ('Администратор', 'admin'), ('Пользователь', 'user')";
                _ = cmd.ExecuteNonQuery();
            }

            // Делаем файл скрытым (если файл существует, атрибут добавится, если нет – команда будет выполнена позже при создании)
            if (File.Exists(DbPath))
            {
                File.SetAttributes(DbPath, File.GetAttributes(DbPath) | FileAttributes.Hidden);
            }
        }

        private static void AddColumnIfMissing(SQLiteConnection conn, string table, string column, string type)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT COUNT(*) FROM pragma_table_info('{table}') WHERE name='{column}'";
            long count = (long)cmd.ExecuteScalar();
            if (count == 0)
            {
                cmd.CommandText = $"ALTER TABLE {table} ADD COLUMN {column} {type}";
                _ = cmd.ExecuteNonQuery();
            }
        }

        // ---------------- Устройства ----------------
        public static List<DeviceInfo> GetAllDevices()
        {
            List<DeviceInfo> list = [];
            using SQLiteConnection conn = new(ConnectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT IP, Port, InstallationPlace, SwitchLabel FROM Devices";
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DeviceInfo
                {
                    IP = reader.GetString(0),
                    Port = reader.GetInt32(1),
                    InstallationPlace = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    SwitchLabel = reader.IsDBNull(3) ? "" : reader.GetString(3)
                });
            }
            return list;
        }

        public static void SaveAllDevices(List<DeviceInfo> devices)
        {
            using SQLiteConnection conn = new(ConnectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            // Очищаем старые записи
            cmd.CommandText = "DELETE FROM Devices";
            _ = cmd.ExecuteNonQuery();

            if (devices.Count == 0)
            {
                return;
            }

            cmd.CommandText = "INSERT INTO Devices (IP, Port, InstallationPlace, SwitchLabel) VALUES (@ip, @p, @pl, @sl)";
            foreach (DeviceInfo d in devices)
            {
                cmd.Parameters.Clear();
                _ = cmd.Parameters.AddWithValue("@ip", d.IP);
                _ = cmd.Parameters.AddWithValue("@p", d.Port);
                _ = cmd.Parameters.AddWithValue("@pl", (object?)d.InstallationPlace ?? DBNull.Value);
                _ = cmd.Parameters.AddWithValue("@sl", (object?)d.SwitchLabel ?? DBNull.Value);
                _ = cmd.ExecuteNonQuery();
            }
        }

        // ---------------- Пароли ----------------
        public static Dictionary<string, string> GetAllPasswords()
        {
            Dictionary<string, string> dict = [];
            using SQLiteConnection conn = new(ConnectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Role, Password FROM Passwords";
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dict[reader.GetString(0)] = reader.GetString(1);
            }
            return dict;
        }

        public static void SavePassword(string role, string password)
        {
            using SQLiteConnection conn = new(ConnectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT OR REPLACE INTO Passwords (Role, Password) VALUES (@r, @p)";
            _ = cmd.Parameters.AddWithValue("@r", role);
            _ = cmd.Parameters.AddWithValue("@p", password);
            _ = cmd.ExecuteNonQuery();
        }

        // ---------------- Журнал действий (без изменений) ----------------
        public static void AddLogEntry(string userRole, string description,
            string? deviceIP = null, float? currentA = null,
            float? resourcePercent = null, string? channel = null)
        {
            using SQLiteConnection conn = new(ConnectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO ChangeLog 
                (Timestamp, UserRole, Description, DeviceIP, CurrentA, ResourcePercent, Channel)
                VALUES (@t, @r, @d, @ip, @ca, @rp, @ch)";
            _ = cmd.Parameters.AddWithValue("@t", DateTime.Now.ToString("o"));
            _ = cmd.Parameters.AddWithValue("@r", userRole);
            _ = cmd.Parameters.AddWithValue("@d", description);
            _ = cmd.Parameters.AddWithValue("@ip", (object?)deviceIP ?? DBNull.Value);
            _ = cmd.Parameters.AddWithValue("@ca", (object?)currentA ?? DBNull.Value);
            _ = cmd.Parameters.AddWithValue("@rp", (object?)resourcePercent ?? DBNull.Value);
            _ = cmd.Parameters.AddWithValue("@ch", (object?)channel ?? DBNull.Value);
            _ = cmd.ExecuteNonQuery();
        }

        public static List<ChangeLogEntry> GetLogEntries(int limit = 500)
        {
            List<ChangeLogEntry> list = [];
            using SQLiteConnection conn = new(ConnectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT Timestamp, UserRole, Description, DeviceIP, CurrentA, ResourcePercent, Channel
                               FROM ChangeLog ORDER BY Id DESC LIMIT @lim";
            _ = cmd.Parameters.AddWithValue("@lim", limit);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ChangeLogEntry
                {
                    Timestamp = DateTime.Parse(reader.GetString(0)),
                    UserRole = reader.GetString(1),
                    Description = reader.GetString(2),
                    DeviceIP = reader.IsDBNull(3) ? null : reader.GetString(3),
                    CurrentA = reader.IsDBNull(4) ? null : reader.GetFloat(4),
                    ResourcePercent = reader.IsDBNull(5) ? null : reader.GetFloat(5),
                    Channel = reader.IsDBNull(6) ? null : reader.GetString(6)
                });
            }
            return list;
        }
    }

    public class ChangeLogEntry
    {
        public DateTime Timestamp { get; set; }
        public required string UserRole { get; set; }
        public required string Description { get; set; }
        public required string DeviceIP { get; set; }
        public float? CurrentA { get; set; }
        public float? ResourcePercent { get; set; }
        public required string Channel { get; set; }
    }
}