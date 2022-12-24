namespace isPointInside.Tests;

public class Tests
{
    [Test]
    public void PointInside()
    {
        Assert.True(isPointInside.PointInside(0, 0));
        Assert.True(isPointInside.PointInside(0, -1));
        Assert.True(isPointInside.PointInside(-1, 0));
        Assert.True(isPointInside.PointInside(0, -2));
    }

    [Test]
    public void PointNotInside()
    {
        Assert.False(isPointInside.PointInside(0, 2));
        Assert.False(isPointInside.PointInside(2, 0));
        Assert.False(isPointInside.PointInside(1, 1));
        Assert.False(isPointInside.PointInside(-2, 0));
    }
}