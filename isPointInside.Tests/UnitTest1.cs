namespace isPointInside.Tests;

public class Tests
{
    [TestCase(0, 0)]
    [TestCase(0, -1)]
    [TestCase(-1, 0)]
    [TestCase(0, 1)]
    public void PointInside(int x, int y)
    {
        Assert.True(isPointInside.PointInside(x, y));
    }

    [TestCase(0, 2)]
    [TestCase(2, 0)]
    [TestCase(1, 1)]
    [TestCase(-2, 0)]
    public void PointNotInside(int x, int y)
    {
        Assert.False(isPointInside.PointInside(x, y));
    }
}