namespace AdventOfCode2024.Day02;

public class Day02PartOne
{
    public static long CalculateResult(string[] input)
    {
        var result = 0;
        var rs = input.Select(l => l.Split(" ").Select(long.Parse).ToList()).ToList();
        foreach (var r in rs)
        {
            var ai = AllIncreasing(r);
            var ad = AllDecreasing(r);
            var adot = AllDifferByOneToThree(r);

            if ((ai || ad) && adot) result++;
        }

        return result;
    }

    private static bool AllIncreasing(IReadOnlyList<long> r)
    {
        var ai = true;
        var i = 0;
        var l = r[0];
        while (ai && i + 1 < r.Count)
        {
            ai = r[i + 1] > l;
            l = r[i + 1];
            i++;
        }

        return ai;
    }

    private static bool AllDecreasing(IReadOnlyList<long> r)
    {
        var ad = true;
        var i = 0;
        var l = r[0];
        while (ad && i + 1 < r.Count)
        {
            ad = r[i + 1] < l;
            l = r[i + 1];
            i++;
        }

        return ad;
    }

    private static bool AllDifferByOneToThree(IReadOnlyList<long> r)
    {
        var result = true;
        var i = 0;
        var l = r[0];
        while (result && i + 1 < r.Count)
        {
            var diff = Math.Abs(r[i + 1] - l);
            result = diff is > 0 and <= 3;
            l = r[i + 1];
            i++;
        }

        return result;
    }
}