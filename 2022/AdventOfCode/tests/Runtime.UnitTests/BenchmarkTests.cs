using System;
using System.Threading;
using Runtime;
using Xunit;

namespace Runtime.UnitTests;

/// <summary>
/// Provides unit tests which exercise the functionality of the 
/// <see cref="Benchmark"/> class.
/// </summary>
public class BenchmarkTests
{
    /// <summary>
    /// Initializes a new instance of the <c>BenchmarkTests</c> class.
    /// </summary>
    public BenchmarkTests()
    {

    }

    /// <summary>
    /// Tests to ensure new instances are created successfully and without exception.
    /// </summary>
    [Fact]
    public void ShouldCreatesNewInstances()
    {
        // arrange

        // act
         var benchmark = new Benchmark();

        // assert
        Assert.NotNull(benchmark);
    }

    /// <summary>
    /// Tests to ensure property accessors get and set appropriately.
    /// </summary>
    [Fact]
    public void ShouldAllowPropertyAccessors()
    {
        // arrange
        var benchmark = new Benchmark();

        // act
        benchmark.Start();
        bool isRunning = benchmark.IsRunning;
        Thread.Sleep(500);
        benchmark.Stop();

        // assert
        Assert.NotNull(benchmark);
        Assert.False(benchmark.IsRunning);
        Assert.NotEqual(benchmark.StartTime, DateTime.MinValue);
        Assert.NotEqual(benchmark.EndTime, DateTime.MinValue);
        Assert.True(benchmark.Elapsed.TotalMilliseconds >= 500);
    }

    /// <summary>
    /// Tests to validate the Start method runs appropriately.
    /// </summary>
    [Fact]
    public void ShouldStartBenchmarkTime()
    {
        // arrange
        var entry = new Benchmark();

        // act
        entry.Start();

        // assert
        Assert.NotNull(entry);
        Assert.True(entry.IsRunning);
        Assert.NotEqual(entry.StartTime, DateTime.MinValue);
    }

    /// <summary>
    /// Tests to ensure Start does not restart when called multiple times.
    /// </summary>
    [Fact]
    public void ShouldNotRestartOnMultipleStartCalls()
    {
        // arrange
        var benchmark = new Benchmark();

        // act
        benchmark.Start();
        DateTimeOffset expected = benchmark.StartTime;
        Thread.Sleep(500);
        benchmark.Start();
        DateTimeOffset actual = benchmark.StartTime;

        // assert
        Assert.NotNull(benchmark);
        Assert.True(benchmark.IsRunning);
        Assert.Equal(expected, actual);
    }

    /// <summary>
    /// Tests to ensure the Stop method stops appropriately.
    /// </summary>
    [Fact]
    public void ShouldStopBenchmarkTime()
    {
        // arrange
        var entry = new Benchmark();

        // act
        entry.Start();
        Thread.Sleep(500);
        entry.Stop();

        // assert
        Assert.NotNull(entry);
        Assert.False(entry.IsRunning);
        Assert.NotEqual(entry.StartTime, DateTime.MinValue);
        Assert.NotEqual(entry.EndTime, DateTime.MinValue);
    }

    /// <summary>
    /// Tests to ensure the Stop method does not reset when called
    /// multiple times.
    /// </summary>
    [Fact]
    public void ShouldNotResetOnMultipleStopCalls()
    {
        // arrange
        Benchmark entry = new Benchmark();

        // act
        entry.Start();
        DateTimeOffset expected = entry.StartTime;
        Thread.Sleep(500);
        entry.Stop();
        Thread.Sleep(500);
        entry.Stop();
        DateTimeOffset actual = entry.StartTime;

        // assert
        Assert.NotNull(entry);
        Assert.False(entry.IsRunning);
        Assert.Equal(expected, actual);
    }

    /// <summary>
    /// Tests to ensure Reset properly updates values.
    /// </summary>
    [Fact]
    public void ShouldResetAppropriately()
    {
        // arrange
        Benchmark entry = new Benchmark();

        // act
        entry.Start();
        Thread.Sleep(500);
        entry.Stop();
        entry.Reset();

        // assert
        Assert.NotNull(entry);
        Assert.False(entry.IsRunning);
        Assert.Equal(entry.StartTime, DateTimeOffset.MinValue);
        Assert.Equal(entry.EndTime, DateTimeOffset.MinValue);
    }

    /// <summary>
    /// Tests to ensure ToString returns properly.
    /// </summary>
    [Fact]
    public void ShouldReturnFormattedString()
    {
        // arrange
        Benchmark entry = new Benchmark();

        // act
        entry.Start();
        Thread.Sleep(500);
        entry.Stop();
        string value = entry.ToString();

        // assert
        Assert.NotNull(entry);
        Assert.False(string.IsNullOrWhiteSpace(value));
    }
}
