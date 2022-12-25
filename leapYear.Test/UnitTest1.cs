namespace leapYear.Test
{
    public class Tests
    {
        [TestCase(2004)]
        [TestCase(2008)]
        [TestCase(2012)]
        [TestCase(2016)]
        [TestCase(2020)]
        [TestCase(2024)]
        public void YearIsLeap(int year)
        {
            Assert.True(leapYears.leapYear(year));
        }

        [TestCase(2001)]
        [TestCase(2002)]
        [TestCase(1999)]
        [TestCase(1998)]
        [TestCase(1957)]
        [TestCase(1953)]
        public void YearIsNotLeap(int year)
        {
            Assert.False(leapYears.leapYear(year));
        }
    }
}