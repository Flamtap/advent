using System.IO;
using System.Linq;
using Advent.Common;

namespace Advent2017
{
    public class Day1 : ISolution
    {
        private readonly int[] _numbers;

        public Day1() => _numbers = File.ReadAllText("./Day1_Input.txt").Select(c => int.Parse(c.ToString())).ToArray();

        /// <summary>
        ///     The captcha requires you to review a sequence of digits (your puzzle input) and find the sum of all
        ///     digits that match the next digit in the list. The list is circular, so the digit after the last digit
        ///     is the first digit in the list.
        /// 
        ///     For example:
        ///       - 1122 produces a sum of 3 (1 + 2) because the first digit(1) matches the second digit and the third
        ///         digit(2) matches the fourth digit.
        ///       - 1111 produces 4 because each digit (all 1) matches the next.
        ///       - 1234 produces 0 because no digit matches the next.
        ///       - 91212129 produces 9 because the only digit that matches the next one is the last digit, 9.
        /// </summary>
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

        /// <summary>
        ///     Now, instead of considering the next digit, it wants you to consider the digit halfway around the
        ///     circular list. That is, if your list contains 10 items, only include a digit in your sum if the digit
        ///     10/2 = 5 steps forward matches it. Fortunately, your list has an even number of elements.
        ///     
        ///     For example:
        ///       - 1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
        ///       - 1221 produces 0, because every comparison is between a 1 and a 2.
        ///       - 123425 produces 4, because both 2s match each other, but no other digit has a match.
        ///       - 123123 produces 12.
        ///       - 12131415 produces 4.
        /// </summary>
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
