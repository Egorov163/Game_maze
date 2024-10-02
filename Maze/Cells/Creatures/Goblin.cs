using Maze.Cells.Creature;
using Maze.LevelStaff;
using System;

namespace Maze.Cells.Creatures
{
    public class Goblin : BaseCreature
    {
        public Goblin(int x, int y, Level level) : base(x, y, level)
        {
        }

        private Random _random = new Random();

        public override ConsoleColor Color => ConsoleColor.Green;

        public override string Simbol => "G";

        public override bool Step(BaseCreature creature)
        {
            if (creature is Goblin)
            {
                return false;
            }
            creature.Hp--;
            return false;
        }

        public override BaseCell ChooseCellToStep()
        {
            var grounds = Level.GetNearCells<BaseCell>(this);// если выбрать землю всё падает
            var randomIndex =  _random.Next(grounds.Count);
            var ground = grounds[randomIndex];
            return ground;
        }
    }
}
