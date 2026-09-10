using System.Drawing;

using System.Windows.Forms;

namespace BCMS
{
    public static class ThemeManager
    {
        // Merkezi renk paleti
        public static Color FormBackColor { get; set; } = Color.LightYellow;
        public static Color ButtonBackColor { get; set; } = Color.SteelBlue;
        public static Color TextColor { get; set; } = Color.White;


        public static void ApplyTheme(Form form)
        {
            form.BackColor = FormBackColor;

            // Formun içindeki tüm kontrolleri rekürsif (özyineli) olarak tara
            ApplyThemeToControls(form.Controls);
        }


        private static void ApplyThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = ButtonBackColor;
                    btn.ForeColor = TextColor;
                    btn.FlatStyle = FlatStyle.Flat;
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = Color.Black;
                }

                // Eğer kontrolün içinde başka kontroller varsa (Panel, GroupBox vb.)
                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
        }
    }
}
