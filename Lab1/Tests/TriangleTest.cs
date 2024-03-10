using Lab1.Classes;

namespace Lab1.Tests;

[TestFixture]
public class TriangleTest
{
    [SetUp]
    public void SetUp()
    {
        _triangle = new Triangle();
    }

    private Triangle _triangle;

    [Test]
    public void CalculateArea_ValidTriangle_ReturnsCorrectResult()
    {
        Assert.That(_triangle.CalculateArea(3, 4, 5), Is.EqualTo(6));
    }

    [Test]
    public void CalculateArea_InvalidTriangle_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _triangle.CalculateArea(1, 2, 3));
    }

    [Test]
    public void CalculateArea_InvalidSideLength_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _triangle.CalculateArea(-1, 2, 3));
    }
}