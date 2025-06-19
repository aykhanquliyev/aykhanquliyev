using NUnit.Framework;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void ValidTriangle_ReturnsTrue()
    {
        Assert.IsTrue(Triangle.CanFormTriangle(3, 4, 5));
    }

    [Test]
    public void InvalidTriangleOneSideTooLong_ReturnsFalse()
    {
        Assert.IsFalse(Triangle.CanFormTriangle(1, 2, 3));
    }

    [Test]
    public void ZeroLengthSide_ReturnsFalse()
    {
        Assert.IsFalse(Triangle.CanFormTriangle(0, 2, 2));
    }

    [Test]
    public void NegativeSide_ReturnsFalse()
    {
        Assert.IsFalse(Triangle.CanFormTriangle(-1, 5, 6));
    }
}