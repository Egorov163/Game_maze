using Maze.Cells;
using System;
using System.Linq;

namespace Maze.LevelStaff
{
    public class LevelDrawer
    {
        public void Draw(Level level)
        {

            foreach (var item in level.Cells)
            {
                Console.SetCursorPosition(item.CoordinateX, item.CoordinateY);
                Console.ForegroundColor = item.Color;
                Console.WriteLine(item.Simbol);
            }

            foreach (var item in level.Creatures)
            {
                Console.SetCursorPosition(item.CoordinateX, item.CoordinateY);
                Console.ForegroundColor = item.Color;
                Console.WriteLine(item.Simbol);
            }

            if (level.Hero != null)
            {
                DrawerStatisticsHero(level);
                Console.SetCursorPosition(level.Hero.CoordinateX, level.Hero.CoordinateY);
                Console.ForegroundColor = level.Hero.Color;
                Console.Write(level.Hero.Simbol);
            }

        }

        private void DrawerStatisticsHero(Level level)
        {
            Console.SetCursorPosition(0, level.Height + 5);
            Console.WriteLine($"Hero" +
                $"\nMoney: {level.Hero.Money}" +
                $"\nHP: {level.Hero.Hp}");

        }
    }
}
