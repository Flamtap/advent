using System.IO;
using System.Linq;
using Advent.Common;

namespace Advent2015
{
    /// <summary>
    ///     http://adventofcode.com/2015/day/2
    /// </summary>
    public class Day2 : ISolution
    {
        private readonly string[] _boxes;

        public Day2() => _boxes = File.ReadAllLines("./Day2_Input.txt");

        public string Part1()
        {
            var total = 0;

            foreach (var box in _boxes.Select(Box.Parse))
            {
                var smallestSide = new[] { box.AreaX, box.AreaY, box.AreaZ }.Min();

                total += smallestSide + box.SurfaceArea;
            }

            return total.ToString();
        }
        
        public string Part2()
        {
            var total = 0;

            foreach (var box in _boxes.Select(Box.Parse))
            {
                var smallestPerimiter = new[] {box.PerimeterX, box.PerimeterY, box.PerimeterZ}.Min();
                
                total += smallestPerimiter + box.Volume;
            }

            return total.ToString();
        }

        public struct Box
        {
            private Box(int length, int width, int height)
            {
                Length = length;
                Width = width;
                Height = height;
            }

            public int Length { get; }

            public int Width { get; }

            public int Height { get; }

            public int AreaX => Height * Length;

            public int AreaY => Length * Width;

            public int AreaZ => Height * Width;

            public int PerimeterX => 2 * Height + 2 * Length;

            public int PerimeterY => 2 * Length + 2 * Width;

            public int PerimeterZ => 2 * Height + 2 * Width;

            public int SurfaceArea => 2 * AreaX + 2 * AreaY + 2 * AreaZ;

            public int Volume => Length * Width * Height;

            public static Box Parse(string value)
            {
                var sides = value.Split('x').Select(int.Parse).ToArray();

                return new Box(sides[0], sides[1], sides[2]);
            }
        }
    }
}