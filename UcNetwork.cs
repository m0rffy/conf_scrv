using System.Globalization;
using static ModBusHelper.ModBusExporterLinker;

namespace Uetm_2_0
{
    public partial class UcNetwork : UserControl
    {
        private ConfiguratorForm mainForm;
        private GeneralSettings_TextFormat settings;

        public UcNetwork(ConfiguratorForm mainForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainForm = mainForm;
            settings = Database.GeneralSettings_TextFormat;
            UpdateFromDatabase();
        }

        public void UpdateFromDatabase()
        {
            settings = Database.GeneralSettings_TextFormat;

            // Ethernet
            if (settings.nets.ownAddr != null && settings.nets.ownAddr.Length >= 6)
            {
                macTextBox.Text = string.Format("{0:X2}:{1:X2}:{2:X2}:{3:X2}:{4:X2}:{5:X2}",
                    settings.nets.ownAddr[0], settings.nets.ownAddr[1], settings.nets.ownAddr[2],
                    settings.nets.ownAddr[3], settings.nets.ownAddr[4], settings.nets.ownAddr[5]);
            }
            else macTextBox.Text = "00:00:00:00:00:00";

            if (settings.nets.ips.ipAddr != null && settings.nets.ips.ipAddr.Length >= 4)
                ipTextBox.Text = string.Format("{0}.{1}.{2}.{3}",
                    settings.nets.ips.ipAddr[0], settings.nets.ips.ipAddr[1],
                    settings.nets.ips.ipAddr[2], settings.nets.ips.ipAddr[3]);
            else ipTextBox.Text = "0.0.0.0";

            if (settings.nets.ips.ipMask != null && settings.nets.ips.ipMask.Length >= 4)
                maskTextBox.Text = string.Format("{0}.{1}.{2}.{3}",
                    settings.nets.ips.ipMask[0], settings.nets.ips.ipMask[1],
                    settings.nets.ips.ipMask[2], settings.nets.ips.ipMask[3]);
            else maskTextBox.Text = "0.0.0.0";

            // PTPv2
            if (settings.syns.ptps.mmadr != null && settings.syns.ptps.mmadr.Length >= 6)
                ptpMasterMacTextBox.Text = string.Format("{0:X2}:{1:X2}:{2:X2}:{3:X2}:{4:X2}:{5:X2}",
                    settings.syns.ptps.mmadr[0], settings.syns.ptps.mmadr[1], settings.syns.ptps.mmadr[2],
                    settings.syns.ptps.mmadr[3], settings.syns.ptps.mmadr[4], settings.syns.ptps.mmadr[5]);
            else ptpMasterMacTextBox.Text = "00:00:00:00:00:00";
            ptpPortTextBox.Text = settings.syns.ptps.id.portNum ?? "-";
            ptpIdTextBox.Text = settings.syns.ptps.id.clkId ?? "-";
        }

        public void SaveToDatabase()
        {
            if (Database.CurrentRole != "Администратор") return;

            // Ethernet
            string[] macParts = macTextBox.Text.Split(':');
            if (macParts.Length == 6)
            {
                for (int i = 0; i < 6; i++)
                    settings.nets.ownAddr[i] = Convert.ToByte(macParts[i], 16);
            }

            string[] ipParts = ipTextBox.Text.Split('.');
            if (ipParts.Length == 4)
            {
                for (int i = 0; i < 4; i++)
                    settings.nets.ips.ipAddr[i] = byte.Parse(ipParts[i]);
            }

            string[] maskParts = maskTextBox.Text.Split('.');
            if (maskParts.Length == 4)
            {
                for (int i = 0; i < 4; i++)
                    settings.nets.ips.ipMask[i] = byte.Parse(maskParts[i]);
            }

            // PTPv2
            string[] ptpMacParts = ptpMasterMacTextBox.Text.Split(':');
            if (ptpMacParts.Length == 6)
            {
                for (int i = 0; i < 6; i++)
                    settings.syns.ptps.mmadr[i] = Convert.ToByte(ptpMacParts[i], 16);
            }

            settings.syns.ptps.id.portNum = ptpPortTextBox.Text;
            settings.syns.ptps.id.clkId = ptpIdTextBox.Text;

            Database.GeneralSettings_TextFormat = settings;
        }
    }
}