using ModBusHelper;
using Newtonsoft.Json;

namespace Uetm_2_0
{
    public static class Database
    {
        public static ModBusExporterLinker.GeneralSettings_TextFormat GeneralSettings_TextFormat;
        public static List<ModBusProfile.journal_record> Filtered_Journal_Records;
        public static string CurrentRole;

        public static List<DeviceInfo> Devices { get; private set; } = new List<DeviceInfo>();

        private static string devicesFilePath = Path.Combine(Application.StartupPath, "devices.json");

        public static void LoadDevices()
        {
            if (File.Exists(devicesFilePath))
            {
                string json = File.ReadAllText(devicesFilePath);
                Devices = JsonConvert.DeserializeObject<List<DeviceInfo>>(json) ?? new List<DeviceInfo>();
            }
            else
            {
                Devices = new List<DeviceInfo>();
            }
        }

        public static void SaveDevices()
        {
            string json = JsonConvert.SerializeObject(Devices, Formatting.Indented);
            File.WriteAllText(devicesFilePath, json);
        }
    }
}