using System;

namespace Runtime.Days;

public class Day06Solver : DaySolverBase
{   
    public Day06Solver() : base(6)
    {
    }

    public override int SolvePart1()
    {
        return FindMarker(_input1, 4);
    }    

    public override int SolvePart2()
    {
        return FindMarker(_input2, 14);
    }

    public static int FindMarker(string input, int packetSize)
    {
        if (string.IsNullOrWhiteSpace(input)) return -1;
        if (packetSize <= 0 || packetSize > input.Length) return -1;

        for (int i = 0; i < input.Length; i++)
        {
            var packet = input.Substring(i, packetSize);
            if (HasUniqueCharacters(packet)) return i + packetSize;
        }

        return -1;
    }

    private static bool HasUniqueCharacters(string input)
    {
        return input.Distinct().Count() == input.Length;
    }
}
