using Maze.LevelStaff;

namespace Maze.Cells
{
    public class Money : BaseSell
    {
        public Money(int x, int y, Level level) : base(x, y, level)
        {
        }
        public override string Simbol => "$";
    }
}
