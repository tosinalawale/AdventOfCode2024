﻿namespace AdventOfCode2024.Day01;

public class Day02PartOne
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

        l.Sort();
        r.Sort();

        var lr = l.Zip(r);

        return lr.Select((x) => Math.Abs(x.First - x.Second)).Sum();
    }
}