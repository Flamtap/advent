using System;
using Advent.Common;

namespace Advent2017
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code 2017 - Eric Sondergard");

            Console.Write("Day to solve:");
            var toSolve = Console.ReadLine();

            if (!int.TryParse(toSolve, out var day))
                return;

            var solution = GetSolution(day);
            Console.WriteLine($"Part 1: {solution.Part1()}");
            Console.WriteLine($"Part 2: {solution.Part2()}");
            Console.ReadKey();
        }

        private static ISolution GetSolution(int day)
        {
            switch (day)
            {
                case 1:
                    return new Day1();
                case 2:
                    return new DummySolution();
                case 3:
                    return new DummySolution();
                case 4:
                    return new DummySolution();
                case 5:
                    return new DummySolution();
                case 6:
                    return new DummySolution();
                case 7:
                    return new DummySolution();
                case 8:
                    return new DummySolution();
                case 9:
                    return new DummySolution();
                case 10:
                    return new DummySolution();
                case 11:
                    return new DummySolution();
                case 12:
                    return new DummySolution();
                case 13:
                    return new DummySolution();
                case 14:
                    return new DummySolution();
                case 15:
                    return new DummySolution();
                case 16:
                    return new DummySolution();
                case 17:
                    return new DummySolution();
                case 18:
                    return new DummySolution();
                case 19:
                    return new DummySolution();
                case 20:
                    return new DummySolution();
                case 21:
                    return new DummySolution();
                case 22:
                    return new DummySolution();
                case 23:
                    return new DummySolution();
                case 24:
                    return new DummySolution();
                case 25:
                    return new DummySolution();
                default:
                    throw new ArgumentOutOfRangeException(nameof(day), day, null);
            }
        }
    }
}