using Uetm_2_0;

public class AppData
{
    public Dictionary<string, string> Passwords { get; set; } = new()
    {
        { "Администратор", "admin" },
        { "Пользователь", "user" }
    };
    public List<DeviceInfo> Devices { get; set; } = new();

    // Простая проверка пароля (без хеширования)
    public static bool VerifyPassword(string role, string password, AppData data)
    {
        return data.Passwords.TryGetValue(role, out string storedPassword) &&
               storedPassword == password;
    }
}