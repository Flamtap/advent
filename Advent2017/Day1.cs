using System.IO;
using System.Linq;
using Advent.Common;

namespace Advent2017
{
    /// <summary>
    ///     http://adventofcode.com/2017/day/1
    /// </summary>
    public class Day1 : ISolution
    {
        private readonly int[] _numbers;

        public Day1() => _numbers = File.ReadAllText("./Day1_Input.txt").Select(c => int.Parse(c.ToString())).ToArray();

        public string Part1()
        {
            var sum = 0;

            for (var i = 0; i < _numbers.Length; i++)
            {
                var j = i + 1 == _numbers.Length
                    ? _numbers[0]
                    : _numbers[i + 1];

                if (_numbers[i] == j)
                    sum += _numbers[i];
            }

            return sum.ToString();
        }

        public string Part2()
        {
            var sum = 0;
            var len = _numbers.Length;
            var half = len / 2;

            for (var i = 0; i < len; i++)
            {
                var j = i + half < len
                    ? _numbers[i + half]
                    : _numbers[i + half - len];

                if (_numbers[i] == j)
                    sum += _numbers[i];
            }

            return sum.ToString();
        }
    }
}
