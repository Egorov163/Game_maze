using Maze.LevelStaff;

namespace Maze.Cells.Creature
{
    public abstract class BaseCreature : BaseSell
    {
        public int Hp { get; set; } = 1;
        public BaseCreature(int x, int y, Level level) : base(x, y, level)
        {
        }       
    }
}
