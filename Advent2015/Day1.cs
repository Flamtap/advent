using System.IO;
using Advent.Common;

namespace Advent2015
{
    /// <summary>
    ///     http://adventofcode.com/2015/day/1
    /// </summary>
    public class Day1 : ISolution
    {
        private readonly string _input;

        public Day1() => _input = File.ReadAllText("./Day1_Input.txt");

        public string Part1()
        {
            var result = 0;

            foreach (var c in _input)
            {
                switch (c)
                {
                    case '(':
                        result++;
                        break;
                    case ')':
                        result--;
                        break;
                }
            }

            return result.ToString();
        }
        
        public string Part2()
        {
            var result = 0;

            for (var i = 0; i < _input.Length; i++)
            {
                switch (_input[i])
                {
                    case '(':
                        result++;
                        break;
                    case ')':
                        result--;
                        break;
                }

                if (result < 0)
                    return (i + 1).ToString();
            }

            return 0.ToString();
        }
    }
}