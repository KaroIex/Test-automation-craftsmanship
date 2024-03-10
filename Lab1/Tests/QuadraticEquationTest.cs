using Lab1.Classes;

namespace Lab1.Tests;

[TestFixture]
public class QuadraticEquationTest
{
    [SetUp]
    public void SetUp()
    {
        _quadraticEquation = new QuadraticEquation();
    }

    private QuadraticEquation _quadraticEquation;

    [Test]
    public void Solve_OneRealSolution_ReturnsCorrectResult()
    {
        Assert.That(_quadraticEquation.Solve(1, 2, 1), Is.EquivalentTo(new double[] { -1 }));
    }

    [Test]
    public void Solve_TwoRealSolutions_ReturnsCorrectResult()
    {
        Assert.That(_quadraticEquation.Solve(1, -3, 2), Is.EquivalentTo(new double[] { 1, 2 }));
    }

    [Test]
    public void Solve_NoRealSolutions_EmptyArray()
    {
        Assert.That(_quadraticEquation.Solve(1, 0, 1), Is.EquivalentTo(Array.Empty<double>()));
    }

    [Test]
    public void Solve_ZeroA_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _quadraticEquation.Solve(0, 1, 1));
    }
}