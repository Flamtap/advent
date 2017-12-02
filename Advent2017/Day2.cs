using System;
using System.IO;
using System.Linq;
using Advent.Common;

namespace Advent2017
{
    /// <summary>
    ///     http://adventofcode.com/2017/day/2
    /// </summary>
    public class Day2 : ISolution
    {
        private readonly string[] _rows;

        public Day2() => _rows = File.ReadAllLines("./Day2_Input.txt");

        public string Part1()
        {
            var checksum = 0;

            foreach (var row in _rows)
            {
                var values = row.Split('\t').Select(int.Parse).ToList();

                checksum += values.Max() - values.Min();
            }

            return checksum.ToString();
        }

        public string Part2()
        {
            var sumOfResults = 0;

            foreach (var row in _rows)
            {
                var values = row.Split('\t').Select(int.Parse).ToList();

                for (var i = 0; i < values.Count - 1; i++)
                {
                    for (var j = 0; j < values.Count; j++)
                    {
                        if (i == j)
                            continue;

                        var v1 = values[i];
                        var v2 = values[j];

                        if (v1 % v2 != 0)
                            continue;

                        sumOfResults += v1 / v2;
                        break;
                    }
                }
            }

            return sumOfResults.ToString();
        }
    }
}
