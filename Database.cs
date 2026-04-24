using ModBusHelper;
using System.Text.Json;

namespace Uetm_2_0
{
    public static class Database
    {
        public static ModBusExporterLinker.GeneralSettings_TextFormat GeneralSettings_TextFormat;
        public static List<ModBusProfile.journal_record> Filtered_Journal_Records;
        public static string CurrentRole;

        private static AppData _appData;
        public static AppData AppData
        {
            get => _appData;
            private set => _appData = value;
        }

        public static List<DeviceInfo> Devices => AppData.Devices;

        static Database()
        {
            LoadAppData();
        }

        public static void LoadAppData()
        {
            try
            {
                string json = LocalDatabase.LoadSetting("AppData");

                if (string.IsNullOrEmpty(json))
                {
                    AppData = new AppData();
                    SaveAppData();
                }
                else
                {
                    AppData = JsonSerializer.Deserialize<AppData>(json) ?? new AppData();
                }
            }
            catch (Exception ex)
            {

                AppData = new AppData();
                SaveAppData();
            }
        }

        public static void SaveAppData()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(AppData, options);
            LocalDatabase.SaveSetting("AppData", json);
        }

        [Obsolete]
        public static void LoadDevices() { }
        [Obsolete]
        public static void SaveDevices() => SaveAppData();
    }
}