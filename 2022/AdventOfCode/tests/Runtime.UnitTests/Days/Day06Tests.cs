using Runtime.Days;
using System;
using Xunit;

namespace Runtime.UnitTests.Days;

public class Day06Tests
{
    public Day06Tests()
    {

    }

    [Fact]
    public void ShouldCreateNewInstances()
    {
        // arrange

        // act
        var day = new Day06();

        // assert
        Assert.NotNull(day);
    }

    [Theory]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz",         4,  5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg",         4,  6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg",    4,  10)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw",     4,  11)]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb",       14, 19)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz",         14, 23)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg",         14, 23)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg",    14,  29)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw",     14,  26)]
    public void ShouldFindMarkerCorrectly(string input, int packetSize, int expectedResult)
    {
        // arrange

        // act

        // assert
        Assert.Equal(expectedResult, Day06.FindMarker(input, packetSize));
    }

    [Fact]
    public void ShouldSolvePart1WithoutError()
    {
        // arrange
        var day = new Day06();

        // act
        var result = day.SolvePart1();

        // assert
        Assert.True(true);
    }

    [Fact]
    public void ShouldSolvePart2WithoutError()
    {
        // arrange
        var day = new Day06();

        // act
        var result = day.SolvePart2();

        // assert
        Assert.True(true);
    }
}
