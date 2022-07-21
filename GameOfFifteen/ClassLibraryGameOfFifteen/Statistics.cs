using System.IO;
using System.Text;

namespace ClassLibraryGameOfFifteen
{
    public class Statistics
    {
        protected string Nickname { get; set; } // нік гравця
        protected int Seconds { get; set; } // час вибраний на гру
        protected int GameLevelTime { get; set; } // час залившийся на гру 
        protected int TotalGameTime { get; set; } // загальний час гри
        protected int CountSteps { get; set; } // кількість кроків виконані під час гри
        
        // логічні поля для деяких методів(звичайна гра чи з часом)
        protected bool OrdinaryOrLevel { get; set; }  
        protected string PathOrdinaryInfo { get; set; }
        protected string PathLevelInfo { get; set; }

        public Statistics()
        {
            PathOrdinaryInfo = @"D:\Політех\1 курс(2 семестр)\ООП\Курсова робота\Програма\GameOfFifteen\RatingInfo\OrdinaryInfo.txt";
            PathLevelInfo = @"D:\Політех\1 курс(2 семестр)\ООП\Курсова робота\Програма\GameOfFifteen\RatingInfo\LevelInfo.txt";
        }

        public Statistics(string nickname, int seconds, int game_level_time, int total_game_time,
            int count_steps, bool ordinary_or_level)
        {
            Nickname = nickname;
            Seconds = seconds;
            GameLevelTime = game_level_time;
            TotalGameTime = total_game_time;
            CountSteps = count_steps;
            OrdinaryOrLevel = ordinary_or_level;
            PathOrdinaryInfo = @"D:\Політех\1 курс(2 семестр)\ООП\Курсова робота\Програма\GameOfFifteen\RatingInfo\OrdinaryInfo.txt";
            PathLevelInfo = @"D:\Політех\1 курс(2 семестр)\ООП\Курсова робота\Програма\GameOfFifteen\RatingInfo\LevelInfo.txt";
        }

        // метод для запису у файл даних класу через отриманий шлях
        private void WritingTextFile(string Path)
        {
            using (FileStream File = new FileStream(Path, FileMode.Append))
            {
                using (StreamWriter Write = new StreamWriter(File, Encoding.UTF8))
                {
                    Write.WriteLine(Nickname);
                    if(OrdinaryOrLevel == false) Write.WriteLine(TotalGameTime);
                    if (OrdinaryOrLevel == true) Write.WriteLine(Seconds - GameLevelTime);
                    Write.WriteLine(CountSteps);
                    Write.WriteLine("--------------------");
                }
            }
        }

        // метод який визначає який рівень гри та передає відповідний шлях до файлу у метод для запису даних
        public void CreateAndWriteTextFile()
        {
            if (OrdinaryOrLevel == false) WritingTextFile(GetPathOrdinaryInfo());            
            if (OrdinaryOrLevel == true) WritingTextFile(GetPathLevelInfo());
        }

        public string GetPathOrdinaryInfo() { return PathOrdinaryInfo; }
        public string GetPathLevelInfo() { return PathLevelInfo; }
    }
}