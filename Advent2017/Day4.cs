using System.ComponentModel;
using System.IO;
using System.Linq;
using Advent.Common;

namespace Advent2017
{
    public class Day4 : ISolution
    {
        private readonly string[] _phrases;

        public Day4() => _phrases = File.ReadAllLines("./Day4_Input.txt");

        public string Part1()
        {
            return _phrases.Select(p => p.Split(' '))
                .Count(words => words.Distinct().Count() == words.Length)
                .ToString();
        }

        public string Part2()
        {
            var count = 0;

            foreach (var phrase in _phrases)
            {
                var words = phrase.Split(' ');
                var distinctWords = words.Select(w => new string(w.OrderBy(x => x).ToArray())).Distinct();

                if (distinctWords.Count() == words.Length)
                    count++;
            }

            return count.ToString();
        }
    }
}
