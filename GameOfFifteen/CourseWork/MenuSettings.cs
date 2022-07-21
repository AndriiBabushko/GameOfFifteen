using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MenuSettings : Form
    {
        Menu MainMenu;
        public MenuSettings()
        {
            InitializeComponent();
        }

        private void MenuSettings_Load(object sender, EventArgs e)
        {
            button_russian.Visible = false;
            button_ukrainian.Visible = false;
            button_english.Visible = false;
        }

        private void button_language_Click(object sender, EventArgs e)
        {
            button_russian.Visible = true;
            button_ukrainian.Visible = true;
            button_english.Visible = true;
            button_language.Visible = false;
        }

        private void button_russian_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
            Properties.Settings.Default.Language = "ru-RU";
            Properties.Settings.Default.Save();
            Refresh();
            button_language.Visible = true;
            button_russian.Visible = false;
            button_ukrainian.Visible = false;
            button_english.Visible = false; 
        }

        private void button_ukrainian_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            Properties.Settings.Default.Language = "ua-UA";
            Properties.Settings.Default.Save();
            Refresh();
            button_language.Visible = true;
            button_russian.Visible = false;
            button_ukrainian.Visible = false;
            button_english.Visible = false;
        }

        private void button_english_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            Properties.Settings.Default.Language = "en-US";
            Properties.Settings.Default.Save();
            Refresh();
            button_language.Visible = true;
            button_russian.Visible = false;
            button_ukrainian.Visible = false;
            button_english.Visible = false;
        }

        private void button_from_settings_to_menu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Localisation.SettingsExitRequest, Localisation.ExitTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                MainMenu = new Menu();
                MainMenu.ShowDialog();
                Close();
            }
        }
    }
}