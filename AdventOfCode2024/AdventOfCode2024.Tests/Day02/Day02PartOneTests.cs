using AdventOfCode2024.Day02;
using FluentAssertions;

namespace AdventOfCode2024.Tests.Day02;

public class Day02PartOneTests
{
    [Test]
    public void PartOne_CalculateResultForSimpleExample()
    {
        const string inputFileText = """
                                     7 6 4 2 1
                                     1 2 7 8 9
                                     9 7 6 2 1
                                     1 3 2 4 5
                                     8 6 4 4 1
                                     1 3 6 7 9
                                     """;

        var input = inputFileText.Split(Environment.NewLine);
        Day02PartOne.CalculateResult(input).Should().Be(2);
    }

    [Test]
    public void PartOne_CalculateResult()
    {
        var input = File.ReadAllLines(@"Input/input02.txt");
        var result = Day02PartOne.CalculateResult(input);
        Console.WriteLine(result);
        result.Should().Be(598);
    }
}