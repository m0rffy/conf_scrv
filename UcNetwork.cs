using ModBusHelper;
using System.Globalization;
using System.Text;
using static ModBusHelper.ModBusExporterLinker;

namespace Uetm_2_0
{
    public partial class UcNetwork : UserControl
    {
        private ConfiguratorForm mainForm;
        private GeneralSettings_TextFormat settings;
        private bool _updating;

        public UcNetwork(ConfiguratorForm mainForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainForm = mainForm;
            _updating = false;
            settings = Database.GeneralSettings_TextFormat;

            SetupInputValidation();
            ApplyRoleRestrictions();
            UpdateFromDatabase();
        }

        private void SetupInputValidation()
        {
            macTextBox.KeyPress += MacAddress_KeyPress;
            macTextBox.TextChanged += MacAddress_TextChanged;
            macTextBox.MaxLength = 17;

            ipTextBox.KeyPress += IpAddress_KeyPress;
            ipTextBox.TextChanged += IpAddress_TextChanged;
            ipTextBox.MaxLength = 15;

            maskTextBox.KeyPress += IpAddress_KeyPress;
            maskTextBox.TextChanged += IpAddress_TextChanged;
            maskTextBox.MaxLength = 15;

            ptpMasterMacTextBox.KeyPress += MacAddress_KeyPress;
            ptpMasterMacTextBox.TextChanged += MacAddress_TextChanged;
            ptpMasterMacTextBox.MaxLength = 17;

            ptpPortTextBox.KeyPress += Port_KeyPress;
            ptpPortTextBox.TextChanged += Port_TextChanged;
            ptpPortTextBox.MaxLength = 5;

            ptpIdTextBox.KeyPress += ClkId_KeyPress;
            ptpIdTextBox.TextChanged += ClkId_TextChanged;
            ptpIdTextBox.MaxLength = 8;
        }

        private void ApplyRoleRestrictions()
        {
            bool isAdmin = Database.CurrentRole == "Администратор";
            macTextBox.ReadOnly = !isAdmin;
            ipTextBox.ReadOnly = !isAdmin;
            maskTextBox.ReadOnly = !isAdmin;
            ptpMasterMacTextBox.ReadOnly = !isAdmin;
            ptpPortTextBox.ReadOnly = !isAdmin;
            ptpIdTextBox.ReadOnly = !isAdmin;

            if (!isAdmin)
            {
                macTextBox.BackColor = SystemColors.Control;
                ipTextBox.BackColor = SystemColors.Control;
                maskTextBox.BackColor = SystemColors.Control;
                ptpMasterMacTextBox.BackColor = SystemColors.Control;
                ptpPortTextBox.BackColor = SystemColors.Control;
                ptpIdTextBox.BackColor = SystemColors.Control;
            }
        }

        #region MAC
        private void MacAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Database.CurrentRole != "Администратор") { e.Handled = true; return; }
            char c = e.KeyChar;
            if (!char.IsControl(c) && !char.IsDigit(c) && !":".Contains(c) &&
                !(c >= 'a' && c <= 'f') && !(c >= 'A' && c <= 'F'))
                e.Handled = true;
        }

        private void MacAddress_TextChanged(object sender, EventArgs e)
        {
            if (_updating) return;
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            string text = tb.Text.ToUpper();
            string formatted = FormatMacAddress(text);
            if (formatted != tb.Text)
            {
                _updating = true;
                int cursor = tb.SelectionStart;
                tb.Text = formatted;
                tb.SelectionStart = Math.Min(cursor + (formatted.Length - text.Length), formatted.Length);
                _updating = false;
            }
        }

        private string FormatMacAddress(string input)
        {
            string digits = new string(input.Where(c => char.IsDigit(c) || (c >= 'A' && c <= 'F')).ToArray());
            if (digits.Length > 12) digits = digits.Substring(0, 12);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < digits.Length; i++)
            {
                if (i > 0 && i % 2 == 0) sb.Append(':');
                sb.Append(digits[i]);
            }
            return sb.ToString();
        }
        #endregion

        #region IP
        private void IpAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Database.CurrentRole != "Администратор") { e.Handled = true; return; }
            char c = e.KeyChar;
            if (!char.IsControl(c) && !char.IsDigit(c) && c != '.')
                e.Handled = true;
        }

        private void IpAddress_TextChanged(object sender, EventArgs e)
        {
            if (_updating) return;
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            string text = tb.Text;
            string filtered = new string(text.Where(c => char.IsDigit(c) || c == '.').ToArray());
            if (filtered.Count(c => c == '.') > 3)
            {
                int dotCount = 0;
                StringBuilder sb = new StringBuilder();
                foreach (char c in filtered)
                {
                    if (c == '.')
                    {
                        dotCount++;
                        if (dotCount <= 3) sb.Append(c);
                    }
                    else sb.Append(c);
                }
                filtered = sb.ToString();
            }

            if (filtered != text)
            {
                _updating = true;
                tb.Text = filtered;
                tb.SelectionStart = filtered.Length;
                _updating = false;
            }
        }
        #endregion

        #region Port
        private void Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Database.CurrentRole != "Администратор") { e.Handled = true; return; }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Port_TextChanged(object sender, EventArgs e)
        {
            if (_updating) return;
            TextBox tb = sender as TextBox;
            if (tb == null) return;
            string text = tb.Text;
            if (string.IsNullOrEmpty(text)) return;

            if (int.TryParse(text, out int port))
            {
                if (port > 65535)
                {
                    _updating = true;
                    tb.Text = "65535";
                    tb.SelectionStart = tb.Text.Length;
                    _updating = false;
                }
            }
            else
            {
                string digits = new string(text.Where(char.IsDigit).ToArray());
                if (digits != text)
                {
                    _updating = true;
                    tb.Text = digits;
                    tb.SelectionStart = digits.Length;
                    _updating = false;
                }
            }
        }
        #endregion

        #region clkId
        private void ClkId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Database.CurrentRole != "Администратор") { e.Handled = true; return; }
            char c = e.KeyChar;
            if (!char.IsControl(c) && !char.IsLetterOrDigit(c) && c != '_' && c != '-')
                e.Handled = true;
        }

        private void ClkId_TextChanged(object sender, EventArgs e)
        {
            if (_updating) return;
            TextBox tb = sender as TextBox;
            if (tb == null) return;
            string text = tb.Text;
            string filtered = new string(text.Where(c => char.IsLetterOrDigit(c) || c == '_' || c == '-').ToArray());
            if (filtered.Length > 8) filtered = filtered.Substring(0, 8);
            if (filtered != text)
            {
                _updating = true;
                tb.Text = filtered;
                tb.SelectionStart = filtered.Length;
                _updating = false;
            }
        }
        #endregion

        public void UpdateFromDatabase()
        {
            if (_updating) return;
            _updating = true;
            settings = Database.GeneralSettings_TextFormat;

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

            if (settings.syns.ptps.mmadr != null && settings.syns.ptps.mmadr.Length >= 6)
                ptpMasterMacTextBox.Text = string.Format("{0:X2}:{1:X2}:{2:X2}:{3:X2}:{4:X2}:{5:X2}",
                    settings.syns.ptps.mmadr[0], settings.syns.ptps.mmadr[1], settings.syns.ptps.mmadr[2],
                    settings.syns.ptps.mmadr[3], settings.syns.ptps.mmadr[4], settings.syns.ptps.mmadr[5]);
            else ptpMasterMacTextBox.Text = "00:00:00:00:00:00";

            ptpPortTextBox.Text = settings.syns.ptps.id.portNum ?? "";
            ptpIdTextBox.Text = settings.syns.ptps.id.clkId ?? "";

            _updating = false;
        }

        public Dictionary<string, string> GetNetworkSettingsDictionary()
        {
            return new Dictionary<string, string>
            {
                ["MAC-адрес"] = macTextBox.Text,
                ["IP-адрес"] = ipTextBox.Text,
                ["Маска подсети"] = maskTextBox.Text,
                ["PTP MAC-адрес мастера"] = ptpMasterMacTextBox.Text,
                ["PTP порт"] = ptpPortTextBox.Text,
                ["PTP идентификатор"] = ptpIdTextBox.Text
            };
        }

        public bool SaveToDatabase()
        {
            if (Database.CurrentRole != "Администратор")
                return false;

            if (!IsValidMacAddress(macTextBox.Text))
            {
                MessageBox.Show("Некорректный MAC-адрес.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateFromDatabase();
                return false;
            }
            if (!IsValidIpAddress(ipTextBox.Text))
            {
                MessageBox.Show("Некорректный IP-адрес.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateFromDatabase();
                return false;
            }
            if (!IsValidIpAddress(maskTextBox.Text))
            {
                MessageBox.Show("Некорректная маска подсети.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateFromDatabase();
                return false;
            }
            if (!IsValidMacAddress(ptpMasterMacTextBox.Text))
            {
                MessageBox.Show("Некорректный PTP MAC-адрес мастера.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateFromDatabase();
                return false;
            }
            if (!int.TryParse(ptpPortTextBox.Text, out int port) || port < 0 || port > 65535)
            {
                MessageBox.Show("Порт должен быть целым числом от 0 до 65535.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateFromDatabase();
                return false;
            }
            if (ptpIdTextBox.Text.Length > 8)
            {
                MessageBox.Show("Идентификатор PTP не может быть длиннее 8 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateFromDatabase();
                return false;
            }
            if (!ModBusFunctions.ValidateStringLength(ptpIdTextBox.Text, 8, out int clkIdBytes))
            {
                MessageBox.Show($"Идентификатор PTP слишком длинный. Максимум 7 байт в UTF-8 (сейчас {clkIdBytes} байт).",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateFromDatabase();
                return false;
            }

            try
            {
                string[] macParts = macTextBox.Text.Split(':');
                for (int i = 0; i < 6; i++)
                    settings.nets.ownAddr[i] = Convert.ToByte(macParts[i], 16);

                string[] ipParts = ipTextBox.Text.Split('.');
                for (int i = 0; i < 4; i++)
                    settings.nets.ips.ipAddr[i] = byte.Parse(ipParts[i]);

                string[] maskParts = maskTextBox.Text.Split('.');
                for (int i = 0; i < 4; i++)
                    settings.nets.ips.ipMask[i] = byte.Parse(maskParts[i]);

                string[] ptpMacParts = ptpMasterMacTextBox.Text.Split(':');
                for (int i = 0; i < 6; i++)
                    settings.syns.ptps.mmadr[i] = Convert.ToByte(ptpMacParts[i], 16);

                settings.syns.ptps.id.portNum = ptpPortTextBox.Text;
                settings.syns.ptps.id.clkId = ptpIdTextBox.Text;

                Database.GeneralSettings_TextFormat = settings;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка преобразования данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateFromDatabase();
                return false;
            }
        }

        private bool IsValidMacAddress(string mac)
        {
            if (string.IsNullOrEmpty(mac)) return false;
            string[] parts = mac.Split(':');
            if (parts.Length != 6) return false;
            foreach (string part in parts)
                if (part.Length != 2 || !System.Text.RegularExpressions.Regex.IsMatch(part, @"^[0-9A-Fa-f]{2}$"))
                    return false;
            return true;
        }

        private bool IsValidIpAddress(string ip)
        {
            if (string.IsNullOrEmpty(ip)) return false;
            string[] parts = ip.Split('.');
            if (parts.Length != 4) return false;
            foreach (string part in parts)
                if (!byte.TryParse(part, out _))
                    return false;
            return true;
        }
    }
}