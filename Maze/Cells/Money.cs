using Maze.Cells.Creature;
using Maze.LevelStaff;
using System;

namespace Maze.Cells
{
    public class Money : BaseSell
    {
        public Money(int x, int y, Level level) : base(x, y, level)
        {
        }
        public override string Simbol => "$";

        public override ConsoleColor Color => ConsoleColor.Green;

        public override bool Step(BaseCreature creature)
        {
            creature.Money++;

            var ground = new Ground(CoordinateX, CoordinateY, Level);          
            Level.Cells.Remove(this);
            Level.Cells.Add(ground);

            return true;
        }
    }
}
