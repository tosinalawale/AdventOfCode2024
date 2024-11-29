using AdventOfCode2024.Day01;
using FluentAssertions;

namespace AdventOfCode2024.Tests.Day01;

public class Day01PartOneTests
{
    [Test]
    public void PartOne_CalculateResultForSimpleExample()
    {
        const string inputFileText = """
                                     Test input goes here
                                     """;

        var input = inputFileText.Split(Environment.NewLine);
        Day01PartOne.CalculateResult(input).Should().Be(1);
    }

    [Test]
    public void PartOne_CalculateResult()
    {
        var input = File.ReadAllLines(@"Input/input01.txt");
        var result = Day01PartOne.CalculateResult(input);
        Console.WriteLine(result);
        result.Should().Be(1);
    }
}