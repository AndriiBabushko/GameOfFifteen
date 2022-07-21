using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Menu : Form
    {
        GameLevels Levels;
        MenuSettings Settings;
        Rating GameRating;
        RACCOON Raccoon;

        public Menu()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            Hide();
            Levels = new GameLevels();
            Levels.ShowDialog();
            Close();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            Hide();
            Settings = new MenuSettings();
            Settings.ShowDialog();
            Close();
        }

        private void button_rating_Click(object sender, EventArgs e)
        {
            Hide();
            GameRating = new Rating();
            GameRating.ShowDialog();
            Close();
        }

        private void ClosingFormInfo()
        {
            if (MessageBox.Show(Localisation.ExitRequest, Localisation.ExitTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
                Close();
            }
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            ClosingFormInfo();
        }

        private void linkLabel_student_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Raccoon = new RACCOON();
            Raccoon.ShowDialog();
            Close();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosingFormInfo();
        }
    }
}