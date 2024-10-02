using Maze.Cells.Creature;
using Maze.LevelStaff;

namespace Maze.Cells
{
    public class Hero : BaseCreature
    {
        public Hero(int x, int y, Level level) : base(x, y, level)
        {
        }

        public override string Simbol => "H";

        public override bool Step(BaseCreature creature)
        {
            return false;
        }
    }
}
