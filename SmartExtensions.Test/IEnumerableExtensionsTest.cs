
using System;
using System.Collections.Generic;
using Xunit;

namespace SmartExtensions.Test
{
    public class IEnumerableExtensionsTest
    {
        [Fact]
        public void TimeSpanSum_ReturnsCorrectSum()
        {
            var expected = TimeSpan.FromHours(6);
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            timeSpans.Add(TimeSpan.FromHours(1));
            timeSpans.Add(TimeSpan.FromHours(2));
            timeSpans.Add(TimeSpan.FromHours(3));
            TimeSpan sum = timeSpans.Sum();// will be 06:00

            Assert.Equal(expected, sum);
        }
    }
}