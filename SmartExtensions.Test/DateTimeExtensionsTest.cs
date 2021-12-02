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

        [Fact]
        public void GetMidnight_ExpectedResult()
        {
            var friday = new DateTime(2020, 5, 29, 17, 15, 30); // monday 3rd of March, 2008, 17h 15m 30s
            var fridayMidnight = new DateTime(2020, 5, 29, 0, 0, 0);
            Assert.Equal(fridayMidnight, friday.GetMidnight());
        }

        [Fact]
        public void GetNoon_ExpectedResult()
        {
            var fridayNoon = new DateTime(2020, 5, 29, 12, 0, 0);
            var friday = new DateTime(2020, 5, 29, 17, 15, 30); // monday 3rd of March, 2008, 17h 15m 30s
            Assert.Equal(fridayNoon, friday.GetNoon());
        }

        [Fact]
        public void SetTimeToMinutePrecision()
        {
            var fridayMidnight = new DateTime(2020, 5, 29, 0, 0, 0);
            DateTime expected = fridayMidnight.AddHours(14).AddMinutes(30);
            var friday = new DateTime(2020, 5, 29, 17, 15, 30); // monday 3rd of March, 2008, 17h 15m 30s

            Assert.Equal(expected, friday.SetTime(14, 30));
        }

        [Fact]
        public void SetTimeToSecondPrecision()
        {
            var fridayMidnight = new DateTime(2020, 5, 29, 0, 0, 0);
            DateTime expected = fridayMidnight.AddHours(14).AddMinutes(30).AddSeconds(15);

            var friday = new DateTime(2020, 5, 29, 17, 15, 30); // monday 3rd of March, 2008, 17h 15m 30s

            Assert.Equal(expected, friday.SetTime(14, 30, 15));
        }

        [Fact]
        public void SetTimeToMillisecondPrecision()
        {
            var fridayMidnight = new DateTime(2020, 5, 29, 0, 0, 0);
            var friday = new DateTime(2020, 5, 29, 17, 15, 30); // monday 3rd of March, 2008, 17h 15m 30s

            DateTime expected = fridayMidnight.AddHours(14).AddMinutes(30).AddSeconds(15).AddMilliseconds(7);
            Assert.Equal(expected, friday.SetTime(14, 30, 15, 7));
        }

        [Fact]
        public void GetAge()
        {
            var dob = new DateTime(1989, 10, 22);

            var age = dob.Age();
            Assert.Equal(32, age);
        }

        [Fact]
        public void ConvertsUnixTimeToUtc()
        {
            const long unixTime = 1599550459;
            var expected = new DateTime(2020, 09, 08, 7, 34, 19, DateTimeKind.Utc);
            Assert.Equal(expected, unixTime.FromUnixEpoch());
        }

        [Fact]
        public void ConvertsUtcToUnixTime()
        {
            const long expected = 1599550459;
            var dt = new DateTime(2020, 09, 08, 7, 34, 19, 0, DateTimeKind.Utc);
            Assert.Equal(expected, dt.ToUnixEpoch());
        }
    }
}
