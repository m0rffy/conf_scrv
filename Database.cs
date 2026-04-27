using ModBusHelper;
using System.Text.Json;

namespace Uetm_2_0
{
    public static class Database
    {
        public static ModBusExporterLinker.GeneralSettings_TextFormat GeneralSettings_TextFormat;
        public static List<ModBusProfile.journal_record> Filtered_Journal_Records;
        public static string CurrentRole;

        private static AppData _appData = new AppData();
        public static AppData AppData
        {
            get => _appData;
            private set => _appData = value;
        }

        public static List<DeviceInfo> Devices
        {
            get => AppData.Devices;
        }

        static Database()
        {
            LoadAppData();
        }

        public static void LoadAppData()
        {
            AppData.Passwords = LocalDatabase.GetAllPasswords();
            AppData.Devices = LocalDatabase.GetAllDevices();
        }

        public static void SaveAppData()
        {
            LocalDatabase.SaveAllDevices(AppData.Devices);
          
        }

       
    }
}