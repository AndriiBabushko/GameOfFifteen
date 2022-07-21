using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ClassLibraryGameOfFifteen;

namespace CourseWork
{
    public partial class Rating : Form
    {
        Statistics Stat;
        Menu MainMenu;

        public Rating()
        {
            InitializeComponent();
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            FileExist();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            FileExist();
        }

        private void FileExist()
        {
            textBox_rating_no_level.Text = "";
            textBox_rating_level.Text = "";
            Stat = new Statistics();
            if (File.Exists(Stat.GetPathOrdinaryInfo()) || File.Exists(Stat.GetPathLevelInfo()))
            {
                if (File.Exists(Stat.GetPathOrdinaryInfo()))
                    ReadOrdinaryInfoTextFile(Stat.GetPathOrdinaryInfo());
                else textBox_rating_no_level.Text += $"{Localisation.RatingNone}";
                if (File.Exists(Stat.GetPathLevelInfo()))
                    ReadLevelInfoTextFile(Stat.GetPathLevelInfo());
                else textBox_rating_level.Text += $"{Localisation.RatingNone}";
            }
            else
            {
                textBox_rating_level.Text += $"{Localisation.RatingNone}";
                textBox_rating_no_level.Text += $"{Localisation.RatingNone}";
                return;
            }
        }

        private async void ReadOrdinaryInfoTextFile(string Path)
        {
            string[] Data; string Line;
            int i = 0, j = 0, Players = 0;
            int[] Indexes = new int[] { 1, 2, 3, 4, 5 };

            using (StreamReader Reader = new StreamReader(Path, Encoding.UTF8))
            {
                while (await Reader.ReadLineAsync() != null) i++; // підрахунок кількості рядків для даних
                Data = new string[i]; // створення масиву рядків для даних
            }

            using (StreamReader Reader = new StreamReader(Path, Encoding.UTF8))
            {
                for (j = 0; (Line = await Reader.ReadLineAsync()) != null; j++) // запис даних у масив рядків 
                {
                    Data[j] = Line;
                }
            }

            i = 0; j = 0;
            textBox_rating_no_level.Text += "#_______________________________________________________________#" + Environment.NewLine;
            while (Players < Data.Length / 4)
            {
                textBox_rating_no_level.Text += $"\t\t№{Players + 1}\t" + Environment.NewLine;
                textBox_rating_no_level.Text += "<-------------------------------------------->" + Environment.NewLine;
                for (; i < Data.Length; i++)
                {
                    WriteNoLevelByIndex(Data, Indexes[j], i);
                    j++;
                    if (Data[i] == "--------------------")
                    {
                        i++;
                        j = 0;
                        break;
                    }
                }
                textBox_rating_no_level.Text += "#________________________________________________________________#" + Environment.NewLine;
                Players++;
            }
        }

        private async void ReadLevelInfoTextFile(string Path)
        {
            string[] Data; string Line;
            int i = 0, j = 0, Players = 0;
            int[] Indexes = new int[] { 1, 2, 3, 4, 5};

            using (StreamReader Reader = new StreamReader(Path, Encoding.UTF8))
            {
                while (await Reader.ReadLineAsync() != null) i++; // підрахунок кількості рядків для даних
                Data = new string[i]; // створення масиву рядків для даних
            }

            using (StreamReader Reader = new StreamReader(Path, Encoding.UTF8))
            {
                for (j = 0; (Line = await Reader.ReadLineAsync()) != null; j++) // запис даних у масив рядків 
                {
                    Data[j] = Line;
                }
            }

            i = 0; j = 0;
            textBox_rating_level.Text += "#_______________________________________________________________#" + Environment.NewLine;
            while (Players < Data.Length / 4)
            {
                textBox_rating_level.Text += $"\t\t№{Players + 1}" + Environment.NewLine;
                textBox_rating_level.Text += "<-------------------------------------------->" + Environment.NewLine;
                for (; i < Data.Length; i++)
                {
                    WriteLevelByIndex(Data, Indexes[j], i);
                    j++;
                    if (Data[i] == "--------------------")
                    {
                        i++;
                        j = 0;
                        break;
                    }
                }
                textBox_rating_level.Text += "#_______________________________________________________________#" + Environment.NewLine;
                Players++;
            }
        }

        private void WriteNoLevelByIndex(string[] Data, int Index, int i)
        {
            if (Index == 1)
            {
                textBox_rating_no_level.Text += $"|\t{Localisation.RatingNickname}: {Data[i]}" + Environment.NewLine;
            }
            if (Index == 2)
            {
                textBox_rating_no_level.Text += $"|\t{Localisation.RatingPassingTime}: {Data[i]} sec." + Environment.NewLine;
            }
            if (Index == 3)
            {
                textBox_rating_no_level.Text += $"|\t{Localisation.RatingMovesNumber}: {Data[i]}" + Environment.NewLine;
            }
        }

        private void WriteLevelByIndex(string[] Data, int Index, int i)
        {
            if (Index == 1)
            {
                textBox_rating_level.Text += $"|\t{Localisation.RatingNickname}: {Data[i]}" + Environment.NewLine;
            }
            if (Index == 2)
            {
                textBox_rating_level.Text += $"|\t{Localisation.RatingPassingTime}: {Data[i]} sec." + Environment.NewLine;
            }
            if (Index == 3)
            {
                textBox_rating_level.Text += $"|\t{Localisation.RatingMovesNumber}: {Data[i]}" + Environment.NewLine;
            }
        }

        private void button_from_rating_to_menu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Localisation.ExitRequest, Localisation.ExitTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                MainMenu = new Menu();
                MainMenu.ShowDialog();
                Close();
            }
        }
    }
}