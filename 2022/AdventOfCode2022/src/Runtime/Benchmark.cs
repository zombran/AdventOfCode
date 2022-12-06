using System;

namespace Runtime;

/// <summary>
/// Provides a means of measuring elapsed time between 
/// two events for the purposes of measuring performance.
/// </summary>
public sealed class Benchmark
{
    private DateTimeOffset _startTime = DateTimeOffset.MinValue;
    private DateTimeOffset _endTime = DateTimeOffset.MinValue;

    private bool _isRunning = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="Benchmark"/> class.
    /// </summary>
    public Benchmark()
    {
    }

    /// <summary>
    /// Gets the time stamp of the benchmark start.
    /// </summary>
    public DateTimeOffset StartTime { get { return _startTime; } }

    /// <summary>
    /// Gets the time stamp of the benchmark end.
    /// </summary>
    public DateTimeOffset EndTime { get { return _endTime; } }

    /// <summary>
    /// Gets the elapsed time between the start and end time.
    /// </summary>
    public TimeSpan Elapsed { get { return _endTime - _startTime; } }

    /// <summary>
    /// Gets a value indicating whether or not the 
    /// benchmark is currently running.
    /// </summary>
    public bool IsRunning { get { return _isRunning; } }

    /// <summary>
    /// Starts the benchmark.
    /// </summary>
    public void Start()
    {
        if (_isRunning) return;
        _startTime = DateTimeOffset.UtcNow;
        _isRunning = true;
    }

    /// <summary>
    /// Stops the benchmark.
    /// </summary>
    public void Stop()
    {
        if (!_isRunning) return;
        _endTime = DateTimeOffset.UtcNow;
        _isRunning = false;
    }

    /// <summary>
    /// Resets the benchmark, stopping any current run, and 
    /// setting start and end time back to their default values.
    /// </summary>
    public void Reset()
    {
        _startTime = DateTimeOffset.MinValue;
        _endTime = DateTimeOffset.MinValue;
        _isRunning = false;
    }

    /// <summary>
    /// Writes the benchmark's elapsed time to a string value.
    /// </summary>
    public override string ToString()
    {
        return Elapsed.ToString("c");
    }
}
