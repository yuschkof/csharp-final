namespace leapYear.Test
{
    public class Tests
    {
        [Test]
        public void YearIsLeapReturnsTrue()
        {
            // multiple of 400
            Assert.True(leapYears.leapYear(2000));
            // multiple of 4 but not 100
            Assert.True(leapYears.leapYear(1004));
        }

        [Test]
        public void YearIsNotLeapReturnsFalse()
        {
            // not multiple of 4
            Assert.False(leapYears.leapYear(2001));
            // multiple of 100 but not 400
            Assert.False(leapYears.leapYear(1900));
        }
    }
}