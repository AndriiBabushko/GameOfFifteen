using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class GameLevels : Form
    {
        GameOfFifteen Fifteen;
        Menu MainMenu;

        public GameLevels()
        {
            InitializeComponent();
            label_nickname.Visible = false;
            textBox_nickname.Visible = false;
            label_choose_time_1.Visible = false;
            trackBar_game_lavel.Visible = false;
            label_OR.Visible = false;
            label_choose_time_2.Visible = false;
            textBox_game_level.Visible = false;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if(radioButton_game_on_time.Checked == false && radioButton_ordinary_game.Checked == false)
            {
                MessageBox.Show(Localisation.LevelsRadioButtonCheked, Localisation.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Nickname; int Seconds = 1;
            if (radioButton_game_on_time.Checked)
            {
                if (textBox_nickname.Text == "")
                {
                    MessageBox.Show(Localisation.NicknameTextbox, Localisation.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox_nickname.Text.Length > 16)
                {
                    MessageBox.Show(Localisation.NicknameLengthTextbox, Localisation.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Nickname = textBox_nickname.Text;
                Properties.Settings.Default.Nickname = Nickname;
                Properties.Settings.Default.Save();
                if (trackBar_game_lavel.Value == 0 && textBox_game_level.Text == "")
                {
                    MessageBox.Show(Localisation.TimeTrackbarTextbox, Localisation.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (trackBar_game_lavel.Value > 0)
                {
                    Seconds = trackBar_game_lavel.Value;
                }
                else
                {
                    if(!int.TryParse(textBox_game_level.Text, out Seconds))
                    { 
                        MessageBox.Show(Localisation.TimeTextbox, Localisation.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if(Seconds != 0)
                {
                    Seconds *= 60;
                    Properties.Settings.Default.Seconds = Seconds;
                    Properties.Settings.Default.Save();
                    Hide();
                    Fifteen = new GameOfFifteen();
                    Fifteen.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(Localisation.TimeTextbox, Localisation.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }

            if (radioButton_ordinary_game.Checked)
            {
                if (textBox_nickname.Text == "")
                {
                    MessageBox.Show(Localisation.NicknameTextbox, Localisation.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox_nickname.Text.Length > 16)
                {
                    MessageBox.Show(Localisation.NicknameLengthTextbox, Localisation.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Nickname = textBox_nickname.Text;
                Properties.Settings.Default.Nickname = Nickname;
                Properties.Settings.Default.Seconds = Seconds;
                Properties.Settings.Default.Save();
                Hide();
                Fifteen = new GameOfFifteen();
                Fifteen.ShowDialog();
                Close();
            }
        }

        private void button_from_game_levels_to_menu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Localisation.ExitRequest, Localisation.ExitTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                MainMenu = new Menu();
                MainMenu.ShowDialog();
                Close();
            }
        }

        private void trackBar_game_lavel_Scroll(object sender, EventArgs e)
        {
            textBox_game_level.Text = $"{trackBar_game_lavel.Value}";
        }

        private void radioButton_game_on_time_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChooseLevel = true;
            Properties.Settings.Default.Save();
            label_nickname.Visible = true;
            textBox_nickname.Visible = true;
            label_choose_time_1.Visible = true;
            trackBar_game_lavel.Visible = true;
            label_OR.Visible = true;
            label_choose_time_2.Visible = true;
            textBox_game_level.Visible = true;
        }

        private void radioButton_ordinary_game_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChooseLevel = false;
            Properties.Settings.Default.Save();
            label_nickname.Visible = true;
            textBox_nickname.Visible = true;
            label_choose_time_1.Visible = false;
            trackBar_game_lavel.Visible = false;
            label_OR.Visible = false;
            label_choose_time_2.Visible = false;
            textBox_game_level.Visible = false;
        }
    }
}