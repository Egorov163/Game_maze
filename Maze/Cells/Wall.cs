﻿using Maze.Cells.Creature;
using Maze.LevelStaff;
using System;

namespace Maze.Cells
{
    public class Wall : BaseCell
    {
        public Wall(int x, int y, Level level) : base(x, y, level)
        {
        }

        public override string Simbol => "#";

        public override ConsoleColor Color => ConsoleColor.DarkGray;

        public override bool Step(BaseCreature creature)
        {
            return false;
        }
    }
}
