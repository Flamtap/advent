using System;
using System.Collections.Generic;
using System.Linq;
using Advent.Common;

namespace Advent2017
{
    public class Day3 : ISolution
    {
        private readonly int _start;

        public Day3() => _start = 361527; //puzzle input

        public string Part1()
        {
            var layers = new List<int[]> {new[] {1}};

            for (int i = 3; !layers.Last().Contains(_start); i = i + 2)
            {
                var lastLayer = layers.Last();
                var lastMax = layers.Last().Max();

                int[] layer = Enumerable.Range(lastMax + 1, i * i - lastMax).ToArray();

                layers.Add(layer);
            }

            return string.Empty;
        }

        public string Part2()
        {
            return string.Empty;
        }
    }
}
