namespace AdventOfCode2024.Day01;

public class Day01PartTwo
{
    public static long CalculateResult(string[] input)
    {
        List<long> l = [];
        List<long> r = [];
        foreach (var s in input)
        {
            var a = s.Split("   ");
            l.Add(long.Parse(a[0]));
            r.Add(long.Parse(a[1]));
        }

        return l.Select(x => x * r.Count(y => y == x)).Sum();
    }
}