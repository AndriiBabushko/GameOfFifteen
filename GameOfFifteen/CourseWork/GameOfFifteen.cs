using System;
using System.Windows.Forms;
using ClassLibraryGameOfFifteen;

namespace CourseWork
{
    public partial class GameOfFifteen : Form
    {
        private Game Game;
        private Statistics Stat;
        private Menu MainMenu;
        private int Min;
        private int TotalGameTime;
        private int GameLevelTime;

        public GameOfFifteen()
        {
            InitializeComponent();
            Game = new Game(4);
            // Game.RandomButtons();
        }

        private void GameOfFifteen_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.ChooseLevel == true)
            {
                timer_game_level_time.Start();
                this.label_total_game_time.Visible = false;
                this.textBox_total_game_time.Visible = false;
                GameLevelTime = Properties.Settings.Default.Seconds;
                Min = GameLevelTime / 60;
                GameLevelTime = GameLevelTime - Min * 60;
            }
            else
            {
                timer_total_game_time.Start();
                this.label_game_level_time.Visible = false;
                this.textBox_game_level_time.Visible = false;
            }
            StartGame();
        }

        // метод який буде визивати інші методи для повного завантаження гри
        private void StartGame()
        {
            Game.Start();
            RefreshButtons();
        }

        // метод повертає потрібну кнопку в залежності від її позиції
        private Button Button(int Position)
        {
            switch (Position)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }
        }

        // метод заповнює поля кнопок відповідними номерами 
        private void RefreshButtons()
        {
            for (int Position = 0; Position < 16; Position++)
            {
                int Number = Game.GetNumber(Position);
                Button(Position).Text = Number.ToString();
                Button(Position).Visible = (Number > 0);
            }
        }

        // метод-подія для руху кнопок при кліку на них та перевірка на те чи кнопки стоять у правильному порядку. 
        private void button0_Click(object sender, EventArgs e)
        {
            int Position = Convert.ToUInt16(((Button)sender).Tag);
            Game.Moving(Position);
            this.textBox_counting_moves.Text = Game.GetCounting().ToString();
            RefreshButtons();
            if (Game.WinCheck())
            {
                timer_total_game_time.Stop();
                timer_game_level_time.Stop();
                int Time;
                if (Properties.Settings.Default.ChooseLevel == false)
                    Time = TotalGameTime + Min * 60;
                else
                    Time = GameLevelTime + Min * 60;
                // запис у файл
                FileDataWriting(Properties.Settings.Default.Nickname, Properties.Settings.Default.Seconds,
                    GameLevelTime, Time, Game.GetCounting(), Properties.Settings.Default.ChooseLevel);
                if (MessageBox.Show(Localisation.UkraineWon, Localisation.RaccoonsGlory, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
                {
                    Hide();
                    MainMenu = new Menu();
                    MainMenu.ShowDialog();
                    Close();
                }
            }
        }

        // метод-подія робить довільну кількість ходів при кліку на відповідну кнопку 
        private void button_random_buttons_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int Steps = random.Next(50, 200);
            for (int i = 0; i < Steps; i++)
            {
                Game.RandomButtons();
            }
            RefreshButtons();
            this.textBox_counting_moves.Text = 0.ToString();
        }

        // метод-подія повернення у меню
        private void button_from_game_to_menu_Click_1(object sender, EventArgs e)
        {
            timer_total_game_time.Stop();
            timer_game_level_time.Stop();
            if (MessageBox.Show(Localisation.SettingsExitRequest, Localisation.ExitTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                MainMenu = new Menu();
                MainMenu.ShowDialog();
                Close();
            }
        }

        // метод-подія таймеру для підрахунку загального часу
        private void timer_total_game_time_Tick(object sender, EventArgs e)
        {
            TotalGameTime++;
            if(TotalGameTime % 60 == 0)
            {
                Min++;
                TotalGameTime = 0;
            }
            this.textBox_total_game_time.Text = $"{Min} min. {TotalGameTime} sec.";
        }

        // метод-подія таймеру для підрахунку часу виділеного для проходження гри
        private void timer_game_level_time_Tick(object sender, EventArgs e)
        {
            if (Min == 0 && GameLevelTime == 0)
            {
                timer_total_game_time.Stop();
                timer_game_level_time.Stop();
                if (MessageBox.Show(Localisation.UkraineLost, Localisation.RaccoonsShame, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
                {
                    Hide();
                    MainMenu = new Menu();
                    MainMenu.ShowDialog();
                    Close();
                };
                return;
            }
            if (GameLevelTime > 0)
                GameLevelTime--;
            else
            {
                Min--;
                GameLevelTime = 60;
            }
            this.textBox_game_level_time.Text = $"{Min} min. {GameLevelTime} sec.";
        }

        // метод запису у файл...
        private void FileDataWriting(string Nickname, int Seconds, int GameLevelTime, int TotalTime, int CountSteps, bool OrdinaryOrLevel)
        {
            Stat = new Statistics(Nickname, Seconds, GameLevelTime,
                TotalTime, CountSteps, OrdinaryOrLevel);
            Stat.CreateAndWriteTextFile();
        }
    }
}