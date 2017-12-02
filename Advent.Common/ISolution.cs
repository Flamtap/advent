namespace Advent.Common
{
    public interface ISolution
    {
        string Input { get; }

        string Part1();

        string Part2();
    }
}
