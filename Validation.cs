namespace Uetm_2_0
{
    public static class Validation
    {
        public static void NumericOnlyCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public static void NumericOnlyCheck_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                string original = textBox.Text;
                string withDot = original.Replace(',', '.');
                string filtered = new string(withDot.Where(c => char.IsDigit(c) || c == '-' || c == '.').ToArray());
                if (original != filtered)
                {
                    textBox.Text = filtered;
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }

        public static void NumericOnly(TextBox textBox)
        {
            textBox.KeyPress += NumericOnlyCheck_KeyPress;
            textBox.TextChanged += NumericOnlyCheck_TextChanged;
        }
    }
}