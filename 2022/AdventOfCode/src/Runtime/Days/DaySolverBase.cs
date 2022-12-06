using System;

namespace Runtime.Days;

public abstract class DaySolverBase : IDaySolver
{
    protected readonly string _input1;
    protected readonly string _input2;

    protected DaySolverBase(int dayId)
    {
        _input1 = string.Empty;
        _input2 = string.Empty;

        string filename = $"Days/inputs/day{dayId.ToString().PadLeft(2, '0')}_1.txt";
        if(File.Exists(filename))
        {
            using var stream = new StreamReader(filename);
            _input1 = stream.ReadToEnd();
        }

        filename = $"Days/inputs/day{dayId.ToString().PadLeft(2, '0')}_2.txt";
        if (File.Exists(filename))
        {
            using var stream = new StreamReader(filename);
            _input2 = stream.ReadToEnd();
        }
    }

    public abstract int SolvePart1();

    public abstract int SolvePart2();
}
