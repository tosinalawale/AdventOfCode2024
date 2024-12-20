using AdventOfCode2024.Day01;
using FluentAssertions;

namespace AdventOfCode2024.Tests.Day01;

public class Day01PartOneTests
{
    [Test]
    public void PartOne_CalculateResultForSimpleExample()
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
        Day02PartOne.CalculateResult(input).Should().Be(11);
    }

    [Test]
    public void PartOne_CalculateResult()
    {
        var input = File.ReadAllLines(@"Input/input01.txt");
        var result = Day02PartOne.CalculateResult(input);
        Console.WriteLine(result);
        result.Should().Be(2285373L);
    }
}