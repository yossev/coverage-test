namespace MyLib.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 3));
    }

    // intentionally NOT testing Subtract so coverage is below 100%
}