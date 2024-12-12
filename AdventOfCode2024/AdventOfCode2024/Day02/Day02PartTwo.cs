namespace AdventOfCode2024.Day02;

public class Day02PartTwo
{
    public static long CalculateResult(string[] input)
    {
        var result = 0;
        var rs = input.Select(l => l.Split(" ").Select(long.Parse).ToList()).ToList();
        foreach (var r in rs)
        {
            if (MatchesCriteria(r)) result++;
            else
            {
                for (var i = 0; i < r.Count; i++)
                {
                    var r2 = new List<long>(r);
                    r2.RemoveAt(i);
                    if (MatchesCriteria(r2))
                    {
                        result++;
                        break;
                    }
                }
            }
        }

        return result;
    }

    private static bool MatchesCriteria(IReadOnlyList<long> r)
    {
        var ai = AllIncreasing(r);
        var ad = AllDecreasing(r);
        var adot = AllDifferByOneToThree(r);

        return (ai || ad) && adot;
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