using System;

namespace Maze.LevelStaff
{
    public class LevelDrawer
    {
        public void Draw(Level level)
        {
            foreach (var item in level.Cells)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.WriteLine(item.Simbol);
            }
        }
    }
}
