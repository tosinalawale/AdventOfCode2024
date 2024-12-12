using AdventOfCode2024.Day01;
using FluentAssertions;

namespace AdventOfCode2024.Tests.Day01;

public class Day01PartTwoTests
{
    [Test]
    public void PartTwo_CalculateResultForSimpleExample()
    {
        const string inputFileText = """
                                     3   4
                                     4   3
                                     2   5
                                     1   3
                                     3   9
                                     3   3
                                     """;

        var input = inputFileText.Split(Environment.NewLine);
        Day01PartTwo.CalculateResult(input).Should().Be(31);
    }

    [Test]
    public void PartTwo_CalculateResult()
    {
        var input = File.ReadAllLines(@"Input/input01.txt");
        var result = Day01PartTwo.CalculateResult(input);
        Console.WriteLine(result);
        result.Should().Be(21142653L);
    }
}