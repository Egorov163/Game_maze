using Maze.Cells;
using System;
using System.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace Maze.LevelStaff
{
    public class LevelBuilder
    {
        private Level _level;
        private Random _random;

        public Level Build(int width = 10, int height = 5, int seedForRandom = -1)
        {
            if (seedForRandom > 0)
            {
                _random = new Random(seedForRandom);
            }
            else
            {
                _random = new Random();
            }

            _level = new Level()
            {
                Width = width,
                Height = height,
            };
            BuildWall();
            BuildGroundRandom();
            BuildMoney();
            BuildHero();

            return _level;
        }

        private void BuildHero()
        {
            var cell = _level.Cells.First(x=>x is Ground);

            var hero = new Hero(cell.CoordinateX, cell.CoordinateY, _level);
            _level.Hero = hero;
        }

        private void BuildGroundRandom()
        {
            var groundCount = _level.Height * _level.Width / 2;

            for (int i = 0; i < groundCount; i++)
            {
                var randomX = _random.Next(_level.Width);
                var randomY = _random.Next(_level.Height);

                var randomWall = _level.Cells.First(x => x.CoordinateX == randomX && x.CoordinateY == randomY);
                var ground = new Ground(randomX, randomY, _level);

                _level.Cells.Remove(randomWall);
                _level.Cells.Add(ground);
            }
        }

        private void BuildWall()
        {
            for (int x = 0; x < _level.Width; x++)
            {
                for (int y = 0; y < _level.Height; y++)
                {
                    var cell = new Wall(x, y, _level);

                    _level.Cells.Add(cell);
                }
            }
        }

        public void BuildMoney()
        {
            var cellGround = _level.Cells.Where(c => c is Ground).ToList();

            for (int i = 0; i < cellGround.Count() / 10; i++)
            {
                var randomGroundIndex = _random.Next(cellGround.Count());
                var randomGround = cellGround[randomGroundIndex];

                var money = new Money(randomGround.CoordinateX, randomGround.CoordinateY, _level);

                _level.Cells.Remove(randomGround);
                _level.Cells.Add(money);
            }
        }
    }
}
