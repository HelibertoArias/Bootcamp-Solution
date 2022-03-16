// <copyright file="SampleCalulatorTests.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using System;
using Xunit;
using Xunit.Abstractions;

namespace Rocco.Logic.Tests;

// Best practices for writing unit tests https://bit.ly/3CCZtff
public class SampleCalulatorTests
{
    private readonly ITestOutputHelper _output;

    public SampleCalulatorTests(ITestOutputHelper output)
    {
        this._output = output;
    }

    [Fact]
    public void SumPositiveNumbers_Should_Sum_Only_Positive_Values()
    {
        // Arrange
        var sut = new SimpleCalculator();

        // Act
        int a = 1;
        int b = 2;
        var result = sut.SumPositiveNumbers(a, b);
        var expected = 3;

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SumPositiveNumbers_Should_Throw_ArgumentException_With_Negative_Values()
    {
        // Arrange
        var sut = new SimpleCalculator();

        // Act
        int a = 1;
        int b = -2;

        // Assert
        Assert.Throws<ArgumentException>(() => sut.SumPositiveNumbers(a, b));
    }

    [Fact]
    public void SumBasic_Should_Sum_Negative_Positive_Values()
    {
        // Arrange
        var sut = new SimpleCalculator();

        // Act
        int a = 1;
        int b = -2;
        int expected = -1;

        var result = sut.SumBasic(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(-1, -1, -2)]
    public void SumBasic_Should_Sum_Negative_Positive_Values_InlineData(int a, int b, int expected)
    {
        _output.WriteLine("Running this test!");
        // Arrange
        var sut = new SimpleCalculator();

        // Act
        //int a = 1;
        //int b = -2;
        //int expected = -1;

        var result = sut.SumBasic(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [SumComplexData]
    public void SumComplex_Should_Sum_Negative_Positive_Values(Item a, Item b, int expected)
    {
        // Arrange
        var sut = new SimpleCalculator();

        // Act
        //int a = 1;
        //int b = -2;
        //int expected = -1;

        var result = sut.SumComplex(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}

