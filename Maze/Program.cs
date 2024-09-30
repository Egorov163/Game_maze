using Maze.LevelStaff;
using System;

namespace Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new LevelBuilder();
            var level = builder.Build(10, 6);

            var drawer = new LevelDrawer();
            drawer.Draw(level);

            Console.ReadLine();

        }
    }
}
