using System;
using Xunit;
using System.Linq;


namespace SmartExtensions.Tests
{
    public class DayTimeExtensionsTests
    {
        private DateTime _monday;

        private DateTime _tuesday;
        private DateTime _nextMonday;


        DateTime _march = new DateTime(2008, 3, 15); // march 15th

        public DayTimeExtensionsTests()
        {
            _monday = new DateTime(2008, 3, 3, 17, 15, 30); // monday 3rd of March, 2008, 17h 15m 30s

            _tuesday = _monday.AddDays(1);
            _nextMonday = _monday.AddDays(7);
        }

        [Fact]
        public void NextWhenDayOfWeekIsAfterCurrentDayOfWeek()
        {
            Assert.Equal(_tuesday, _monday.NextSpecificDay(DayOfWeek.Tuesday));
        }

        [Fact]
        public void NextWhenDayOfWeekIsBeforeCurrentDayOfWeek()
        {
            Assert.Equal(_nextMonday, _tuesday.NextSpecificDay(DayOfWeek.Monday));
        }

        [Fact]
        public void NextWhenDayOfWeekIsSameAsCurrentDayOfWeek()
        {
            Assert.Equal(_nextMonday, _monday.NextSpecificDay(DayOfWeek.Monday));
        }

        [Fact]
        public void FirstDayOfMonth()
        {
            DateTime expected = new DateTime(_monday.Year, _monday.Month, 1);

            Assert.Equal(expected, _march.FirstDayOfMonth());
        }

        [Fact]
        public void FirstSpecificDayOfMonth()
        {
            DateTime expected = new DateTime(_monday.Year, _monday.Month, 3); // first monday in march 2008

            Assert.Equal(expected, _march.FirstDayOfMonth(DayOfWeek.Monday));
        }

        [Fact]
        public void FirstSpecificDayOfMonthWhenItIsReallyFirstDayOfMonth()
        {
            DateTime expected = new DateTime(2008, 3, 1); // first saturday in march 2008

            Assert.Equal(DayOfWeek.Saturday, expected.DayOfWeek);
            Assert.Equal(expected, _march.FirstDayOfMonth(DayOfWeek.Saturday));
        }

        [Fact]
        public void LastDayOfMonth()
        {
            DateTime expected = new DateTime(_march.Year, _march.Month, DateTime.DaysInMonth(_march.Year, _march.Month));

            Assert.Equal(expected, _march.LastDayOfMonth());
        }

        [Fact]
        public void LastSpecificDayOfMonth()
        {
            DateTime expected = new DateTime(_march.Year, _march.Month, DateTime.DaysInMonth(_march.Year, _march.Month));

            while (expected.DayOfWeek != DayOfWeek.Sunday)
            {
                expected = expected.AddDays(-1);
            }

            Assert.Equal(expected, _march.LastDayOfMonth(DayOfWeek.Sunday));
        }

        [Fact]
        public void LastSpecificDayOfMonthWhenItIsReallyLastDayOfMonth()
        {
            DateTime expected = new DateTime(2008, 3, 31); // last day in march 2008 = monday

            Assert.Equal(DayOfWeek.Monday, expected.DayOfWeek);
            Assert.Equal(expected, _march.LastDayOfMonth(DayOfWeek.Monday));

        }
    }
}
