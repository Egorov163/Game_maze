﻿using Maze.Cells.Creature;
using Maze.LevelStaff;
using System;

namespace Maze.Cells
{
    public abstract class BaseCell
    {
        public BaseCell(int x, int y, Level level)
        {
            CoordinateX = x;
            CoordinateY = y;
            Level = level;
        }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public Level Level { get; set; }

        public abstract ConsoleColor Color { get; }

        public abstract string Simbol { get; }
        public abstract bool Step(BaseCreature creature);

    }
}
