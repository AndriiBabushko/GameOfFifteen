using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RACCOON : Form
    {
        int Clicks;

        public RACCOON()
        {
            InitializeComponent();
            Clicks = 0;
        }

        private void RACOON_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show(Localisation.ExitRequest, Localisation.ExitTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                Menu MainMenu = new Menu();
                MainMenu.ShowDialog();
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clicks++;
            textBox_clicks.Text = $"{Localisation.Clicks}: {Clicks}";
            if (Clicks > 5 && Clicks < 10) label_click_on_raccoon.Text = $"{Localisation.RaccoonLittleAttention}";
            if (Clicks > 10 && Clicks < 25) label_click_on_raccoon.Text = $"{Localisation.RaccoonNeedsMoreAttention}";
            if (Clicks > 50 && Clicks < 100) label_click_on_raccoon.Text = $"{Localisation.RaccoonEnoughAttention}";
            if (Clicks > 100) label_click_on_raccoon.Text = $"{Localisation.RaccoonALotAttention}";
        }
    }
}