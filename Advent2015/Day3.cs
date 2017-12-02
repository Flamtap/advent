using System.Collections.Generic;
using System.IO;
using System.Linq;
using Advent.Common;

namespace Advent2015
{
    /// <summary>
    ///     http://adventofcode.com/2015/day/3/answer
    /// </summary>
    public class Day3 : ISolution
    {
        private readonly string _moves;

        public Day3() => _moves = File.ReadAllText("./Day3_Input.txt");

        public string Part1()
        {
            var houses = new List<(int, int)> { (0, 0) };

            var x = 0;
            var y = 0;

            foreach (var move in _moves)
            {
                switch (move)
                {
                    case '>':
                        x++; break;

                    case '<':
                        x--; break;

                    case '^':
                        y++; break;

                    case 'v':
                        y--; break;
                }

                houses.Add((x, y));
            }

            return houses.Distinct().Count().ToString();
        }

        public string Part2()
        {
            var houses = new List<(int, int)> { (0, 0) };

            var santaX = 0;
            var santaY = 0;

            var santaMoves = _moves.Where((p, index) => index % 2 == 0);
            var roboMoves = _moves.Skip(1).Where((p, index) => index % 2 == 0);

            foreach (var move in santaMoves)
            {
                switch (move)
                {
                    case '>':
                        santaX++; break;

                    case '<':
                        santaX--; break;

                    case '^':
                        santaY++; break;

                    case 'v':
                        santaY--; break;
                }

                houses.Add((santaX, santaY));
            }

            var roboX = 0;
            var roboY = 0;

            foreach (var move in roboMoves)
            {
                switch (move)
                {
                    case '>':
                        roboX++; break;

                    case '<':
                        roboX--; break;

                    case '^':
                        roboY++; break;

                    case 'v':
                        roboY--; break;
                }

                houses.Add((roboX, roboY));
            }

            return houses.Distinct().Count().ToString();
        }
    }
}
