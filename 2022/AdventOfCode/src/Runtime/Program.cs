using Runtime;
using Runtime.Days;

List<IDaySolver> solvers = new List<IDaySolver>()
{
    new Day06Solver()
};

foreach(IDaySolver solver in solvers)
{
    var benchmark = new Benchmark();
    benchmark.Start();
    var part1Solution = solver.SolvePart1();
    benchmark.Stop();

    var part1Elapsed = benchmark.Elapsed;
    benchmark.Reset();

    benchmark.Start();
    var part2Solution = solver.SolvePart2();
    benchmark.Stop();

    var part2Elapsed = benchmark.Elapsed;

    Console.WriteLine($"{solver.GetType().Name }");
    Console.WriteLine($" | Part 1: \t{part1Solution} in {part1Elapsed.ToString("c")}");
    Console.WriteLine($" | Part 2: \t{part2Solution} in {part2Elapsed.ToString("c")}");
}
