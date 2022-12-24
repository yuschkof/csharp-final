using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace isPointInside.Test;

public class UnitTest1
{
    [Test]
    public void YearIsLeapReturnsTrue()
    {
        // multiple of 400
        Assert.True(PointInside(0, 0));
        // multiple of 4 but not 100
        Assert.True(LeapYearService.IsLeapYear(1004));
    }

    [Test]
    public void YearIsNotLeapReturnsFalse()
    {
        // not multiple of 4
        Assert.False(LeapYearService.IsLeapYear(2001));
        // multiple of 100 but not 400
        Assert.False(LeapYearService.IsLeapYear(1900));
    }
}
