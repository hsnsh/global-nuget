using FluentAssertions;

namespace HsNsH.GlobalNuGet.Calculator.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(1.0, 2.0, 3.0)]
    public void Add_GivenValidInput_ReturnSuccessResult(double x, double y, double expected)
    {
        // Arrange
        ICalculator calc = new Calculator();

        // Act
        var actual = calc.Add(x, y);

        // Assert
        actual.Should().Be(expected);
    }
}