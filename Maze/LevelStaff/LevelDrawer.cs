using Maze.Cells;
using System;

namespace Maze.LevelStaff
{
    public class LevelDrawer
    {
        public void Draw(Level level)
        {
            foreach (var item in level.Cells)
            {
                Console.SetCursorPosition(item.CoordinateX, item.CoordinateY);
                Console.WriteLine(item.Simbol);
            }

            Console.SetCursorPosition(level.Hero.CoordinateX, level.Hero.CoordinateY);
            Console.Write(level.Hero.Simbol);
        }
    }
}
