using System.Data.SQLite;

namespace Uetm_2_0
{
    public static class LocalDatabase
    {
        internal static readonly string DbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Uetm_2_0",
            "config.db");
        //%LocalAppData%\Uetm_2_0\config.db
        internal static readonly string ConnectionString = $"Data Source={DbPath};Version=3;";

        static LocalDatabase()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DbPath) ?? "");

            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();

            // Таблицы
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS AppSettings (
                    Key TEXT PRIMARY KEY,
                    Value TEXT NOT NULL
                );
                CREATE TABLE IF NOT EXISTS ChangeLog (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Timestamp TEXT NOT NULL,
                    UserRole TEXT NOT NULL,
                    Description TEXT NOT NULL
                );";
            cmd.ExecuteNonQuery();

            // Добавляем недостающие столбцы в ChangeLog, если их нет
            AddColumnIfMissing(conn, "ChangeLog", "DeviceIP", "TEXT");
            AddColumnIfMissing(conn, "ChangeLog", "CurrentA", "REAL");
            AddColumnIfMissing(conn, "ChangeLog", "ResourcePercent", "REAL");
            AddColumnIfMissing(conn, "ChangeLog", "Channel", "TEXT");
        }

        private static void AddColumnIfMissing(SQLiteConnection conn, string table, string column, string type)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT COUNT(*) FROM pragma_table_info('{table}') WHERE name='{column}'";
            long count = (long)cmd.ExecuteScalar();
            if (count == 0)
            {
                cmd.CommandText = $"ALTER TABLE {table} ADD COLUMN {column} {type}";
                cmd.ExecuteNonQuery();
            }
        }

        // --------------------- Настройки ---------------------
        public static void SaveSetting(string key, string value)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT OR REPLACE INTO AppSettings (Key, Value) VALUES (@k, @v)";
            cmd.Parameters.AddWithValue("@k", key);
            cmd.Parameters.AddWithValue("@v", value);
            cmd.ExecuteNonQuery();
        }

        public static string LoadSetting(string key)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Value FROM AppSettings WHERE Key = @k";
            cmd.Parameters.AddWithValue("@k", key);
            var result = cmd.ExecuteScalar();
            return result?.ToString();
        }

        // --------------------- Журнал действий ---------------------
        public static void AddLogEntry(string userRole, string description,
            string deviceIP = null, float? currentA = null,
            float? resourcePercent = null, string channel = null)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO ChangeLog 
                (Timestamp, UserRole, Description, DeviceIP, CurrentA, ResourcePercent, Channel)
                VALUES (@t, @r, @d, @ip, @ca, @rp, @ch)";
            cmd.Parameters.AddWithValue("@t", DateTime.Now.ToString("o"));
            cmd.Parameters.AddWithValue("@r", userRole);
            cmd.Parameters.AddWithValue("@d", description);
            cmd.Parameters.AddWithValue("@ip", (object?)deviceIP ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ca", (object?)currentA ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@rp", (object?)resourcePercent ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ch", (object?)channel ?? DBNull.Value);
            cmd.ExecuteNonQuery();
        }

        public static List<ChangeLogEntry> GetLogEntries(int limit = 500)
        {
            var list = new List<ChangeLogEntry>();
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT Timestamp, UserRole, Description, DeviceIP, CurrentA, ResourcePercent, Channel
                               FROM ChangeLog ORDER BY Id DESC LIMIT @lim";
            cmd.Parameters.AddWithValue("@lim", limit);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ChangeLogEntry
                {
                    Timestamp = DateTime.Parse(reader.GetString(0)),
                    UserRole = reader.GetString(1),
                    Description = reader.GetString(2),
                    DeviceIP = reader.IsDBNull(3) ? null : reader.GetString(3),
                    CurrentA = reader.IsDBNull(4) ? null : (float?)reader.GetFloat(4),
                    ResourcePercent = reader.IsDBNull(5) ? null : (float?)reader.GetFloat(5),
                    Channel = reader.IsDBNull(6) ? null : reader.GetString(6)
                });
            }
            return list;
        }
    }

    public class ChangeLogEntry
    {
        public DateTime Timestamp { get; set; }
        public string UserRole { get; set; }
        public string Description { get; set; }
        public string DeviceIP { get; set; }
        public float? CurrentA { get; set; }
        public float? ResourcePercent { get; set; }
        public string Channel { get; set; }
    }
}