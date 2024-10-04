using Maze.Cells;
using Maze.Cells.Creature;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Maze.LevelStaff
{
    public class Level
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<BaseCell> Cells { get; set; } = new List<BaseCell>();
        public List<BaseCreature> Creatures { get; set; } = new List<BaseCreature>();
        public Hero Hero { get; set; }

        public void ReplaceCell(BaseCell oldCell, BaseCell newCell)
        {
            Cells.Remove(oldCell);
            Cells.Add(newCell);
        }
        public void ReplaceToGround(BaseCell cell)
        {
            var ground = new Ground(cell.CoordinateX, cell.CoordinateY, this);
            ReplaceCell(cell, ground);
        }

        public List<TYPE> GetNearCells<TYPE>(BaseCell currentCell)
            where TYPE : BaseCell
        {
            return Cells
                .Where(cell => cell.CoordinateX == currentCell.CoordinateX
                    && Math.Abs(cell.CoordinateY - currentCell.CoordinateY) == 1
                    ||
                    Math.Abs(cell.CoordinateX - currentCell.CoordinateX) == 1
                && cell.CoordinateY == currentCell.CoordinateY)
                .OfType<TYPE>()
                .ToList();
        }

    }
}
