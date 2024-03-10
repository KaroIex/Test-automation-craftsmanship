using Lab1.Classes;

namespace Lab1.Tests;

[TestFixture]
public class CalculatorTest
{
    [SetUp] //przed każdym testem
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    private Calculator _calculator;


    [Test]
    public void AdditionOfTwoPositiveNumbers_ReturnsCorrectResult()
    {
        Assert.That(_calculator.Add(2, 2), Is.EqualTo(4));
    }

    [Test]
    public void AdditionOfPositiveAndNegativeNumber_ReturnsCorrectResult()
    {
        Assert.That(_calculator.Add(4, -5), Is.EqualTo(-1));
    }

    [Test]
    public void DivisionByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => { _calculator.Div(23, 0); });
    }

    [Test]
    public void MultiplicationOfTwoPositiveNumbers_ReturnsCorrectResult()
    {
        Assert.That(_calculator.Mul(3, 3), Is.EqualTo(9));
    }

    [Test]
    public void MultiplicationOfPositiveAndNegativeNumbers_ReturnsCorrectResult()
    {
        Assert.That(_calculator.Mul(-5, 4), Is.EqualTo(-20));
    }

    [Test]
    public void SubtractionOfTwoPositiveNumbers_ReturnsCorrectResult()
    {
        Assert.That(_calculator.Sub(10, 4), Is.EqualTo(6));
    }

    [Test]
    public void SubtractionOfPositiveAndNegativeNumbers_ReturnsCorrectResult()
    {
        Assert.That(_calculator.Sub(-5, 4), Is.EqualTo(-9));
    }
}