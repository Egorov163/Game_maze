using Maze.Cells.Creature;
using Maze.LevelStaff;
using System;

namespace Maze.Cells
{
    public class Ground : BaseCell
    {
        public Ground(int x, int y, Level level) : base(x, y, level)
        {
        }
        public override string Simbol => " ";

        public override ConsoleColor Color => ConsoleColor.Green;

        public override bool Step(BaseCreature creature)
        {
            return true;
        }
    }
}
