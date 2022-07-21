using System;

namespace ClassLibraryGameOfFifteen
{
    public class Game
    {
        protected int[,] Map; // Номери кожної кнопки 
        protected int Size; // розмір гри
        protected int SpaceX, SpaceY; // координати де саме знаходиться 0 у карті Map
        protected int CountingSteps; // кількість кліків гравцем на кнопки 

        static Random Random = new Random();

        public Game(int size)
        {
            if (size < 2) size = 2;
            if (size > 5) size = 5;
            this.Size = size;
            Map = new int[Size, Size];
        }

        // метод для ініціалізації даних класу та старту програми
        public void Start()
        {
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Map[x, y] = CoordinatesToPosition(x, y) + 1;
                }
            }
            SpaceX = Size - 1;
            SpaceY = Size - 1;
            Map[SpaceX, SpaceY] = 0;
        }

        // метод який після отримання позиції повертає номер відповідної кнопки
        public int GetNumber(int Position)
        {
            int x, y;
            PositionToCoordinates(Position, out x, out y);
            // перевірка чи виходять координати за межі масиву
            if (x < 0 || x >= Size) return 0;
            if (y < 0 || y >= Size) return 0;
            return Map[x, y];
        }

        // метод переводить координати у позицію кнопки(її номер)
        private int CoordinatesToPosition(int x, int y)
        {
            // перевірка чи виходять координати за межі масиву
            if (x < 0) x = 0;
            if (x > Size - 1) x = Size - 1;
            if (y < 0) y = 0;
            if (y > Size - 1) y = Size - 1;
            return y * Size + x;
        }

        // метод переводить позицію кнопки(її номер) у координати цієї кнопки
        private void PositionToCoordinates(int Position, out int x, out int y)
        {
            if (Position < 0) Position = 0;
            if (Position > Size * Size - 1) Position = Size * Size - 1;
            x = Position % Size;
            y = Position / Size;
        }

        // метод для руху кнопок лише тих, які стоять поряд з пустим полем 
        public void Moving(int Position)
        {
            int x, y;
            PositionToCoordinates(Position, out x, out y);
            if (Math.Abs(SpaceX - x) + Math.Abs(SpaceY - y) != 1) return; // якщо кнопка не є сусідньою, тоді нічого не робимо
            else
            {
                CountingSteps++;
                Map[SpaceX, SpaceY] = Map[x, y];
                Map[x, y] = 0;
                SpaceX = x; SpaceY = y;
            }
        }

        // метод робить довільний хід кнопкою 0 (проблема гри 15), бо якщо не 0 може таке бути
        // що гру не буде можливо пройти(виграти)
        public void RandomButtons()
        {
            CountingSteps = 0;
            int Moves = Random.Next(0, 4); // кількість сторін на яку може піти кнопка 
            int x = SpaceX;
            int y = SpaceY;
            switch (Moves)
            {
                case 0:
                    {
                        x--;
                        break;
                    }
                case 1:
                    {
                        x++;
                        break;
                    }
                case 2:
                    {
                        y--;
                        break;
                    }
                case 3:
                    {
                        y++;
                        break;
                    }
            }
            int Position = CoordinatesToPosition(x, y);
            x = 0; y = 0;
            PositionToCoordinates(Position, out x, out y);
            if (Math.Abs(SpaceX - x) + Math.Abs(SpaceY - y) != 1) return; // якщо кнопка не є сусідньою, тоді нічого не робимо
            else
            {
                Map[SpaceX, SpaceY] = Map[x, y];
                Map[x, y] = 0;
                SpaceX = x; SpaceY = y;
            }
        }

        // метод для перевірки чи всі кнопки стоять на своїх місцях 
        public bool WinCheck()
        {
            if (!(SpaceX == Size - 1 && SpaceY == Size - 1)) 
                return false;
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    if (!(x == Size - 1 && y == Size - 1)) 
                        if (Map[x, y] != CoordinatesToPosition(x, y) + 1) 
                            return false;
                }
            }
            return true;
        }

        public int GetCounting() { return CountingSteps; }
    }
}