using ModBusHelper;

namespace Uetm_2_0
{
    public static class Database
    {
        public static ModBusExporterLinker.GeneralSettings_TextFormat GeneralSettings_TextFormat;
        public static List<ModBusProfile.journal_record> Filtered_Journal_Records;
        public static string CurrentRole;

        public static AppData AppData { get; private set; } = new AppData();

        public static List<DeviceInfo> Devices => AppData.Devices;

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