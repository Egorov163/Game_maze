using Maze.Cells;
using System.Collections.Generic;

namespace Maze.LevelStaff
{
    public class Level
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<BaseSell> Cells { get; set; } = new List<BaseSell>();
        public Hero Hero { get; set; }

    }
}
