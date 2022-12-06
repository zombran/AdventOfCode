using System;

namespace Runtime.Days;

public class Day06 : DayBase
{   
    public Day06() : base(6)
    {
    }

    public override int SolvePart1()
    {
        var input = _input1;
        const int packetSize = 4;
        if (string.IsNullOrWhiteSpace(input)) return -1;

        for(int i = 0; i < input.Length; i++)
        {
            var packet = input.Substring(i, packetSize);
            if (HasUniqueCharacters(packet)) return i + packetSize;
        }

        return -1;
    }    

    public override int SolvePart2()
    {
        var input = _input2;
        const int packetSize = 14;
        if (string.IsNullOrWhiteSpace(input)) return -1;

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
