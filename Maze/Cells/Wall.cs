using Maze.LevelStaff;

namespace Maze.Cells
{
    public class Wall : BaseSell
    {
        public Wall(int x, int y, Level level) : base(x, y, level)
        {
        }

        public override string Simbol => "#";
    }
}
