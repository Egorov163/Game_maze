using Maze.LevelStaff;

namespace Maze.Cells
{
    public class Ground : BaseSell
    {
        public Ground(int x, int y, Level level) : base(x, y, level)
        {
        }
        public override string Simbol => " ";
    }
}
