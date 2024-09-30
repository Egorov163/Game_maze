using Maze.LevelStaff;

namespace Maze.Cells
{
    public abstract class BaseSell
    {
        public BaseSell(int x, int y, Level level)
        {
            X = x;
            Y = y;
            Level = level;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public Level Level { get; set; }
        public abstract string Simbol { get; }

    }
}
