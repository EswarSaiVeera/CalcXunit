using CalcXunit;
using Xunit;

public class CalcXtesting
{
    [Fact]
    public void Add_Returns_Sum()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 3));
    }

    [Fact]
    public void Subtract_Returns_Difference()
    {
        var calc = new Calculator();
        Assert.Equal(1, calc.Subtract(4, 3));
    }

    [Fact]
    public void Multiply_Returns_Product()
    {
        var calc = new Calculator();
        Assert.Equal(6, calc.Multiply(2, 3));
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(9, 3, 3)]
    public void Divide_Returns_Quotient(int dividend, int divisor, double expected)
    {
        var calc = new Calculator();
        Assert.Equal(expected, calc.Divide(dividend, divisor));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        var calc = new Calculator();
        Assert.Throws<ArgumentException>(() => calc.Divide(1, 0));
    }
}
