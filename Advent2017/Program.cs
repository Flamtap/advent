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
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    return new DummySolution();
                default:
                    throw new ArgumentOutOfRangeException(nameof(day), day, null);
            }
        }
    }
}