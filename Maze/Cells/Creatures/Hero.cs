using Maze.Cells.Creature;
using Maze.LevelStaff;
using System;

namespace Maze.Cells
{
    public class Hero : BaseCreature
    {
        public Hero(int x, int y, Level level) : base(x, y, level)
        {
        }

        public override string Simbol => "H";

        public override ConsoleColor Color => ConsoleColor.White;

        public override bool ActionStep(BaseCreature creature)
        {
            throw new System.NotImplementedException();
        }
    }
}
