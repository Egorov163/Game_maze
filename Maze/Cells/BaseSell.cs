using Maze.Cells.Creature;
using Maze.LevelStaff;

namespace Maze.Cells
{
    public abstract class BaseSell
    {
        public BaseSell(int x, int y, Level level)
        {
            CoordinateX = x;
            CoordinateY = y;
            Level = level;
        }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public Level Level { get; set; }

        public abstract string Simbol { get; }
        public abstract bool Step(BaseCreature creature);

    }
}
