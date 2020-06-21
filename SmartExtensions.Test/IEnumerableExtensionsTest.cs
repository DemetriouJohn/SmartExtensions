
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

        [Fact]
        public void IsNullOrEmpty_Empty_True()
        {
            var list = new List<string>();
            Assert.True(list.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_NotEmpty_False()
        {
            var list = new List<string>();
            list.Add("Test1");
            list.Add("Test2");
            Assert.False(list.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_Null_True()
        {
            List<string> list = null;
            Assert.True(list.IsNullOrEmpty());
        }

        [Fact]
        public void StandardDeviationPopulation_ExpectedResult()
        {
            var nums = new[] { 11, 12, 13, 12, 13, 15, 12, 14, 15, 15, 12, 14, 15 };
            //Prints out the standard deviation of the entire data set (population)
            Assert.Equal(1.3803352649943355, nums.StandardDeviationPopulation());
        }

        [Fact]
        public void StandardDeviation_ExpectedResult()
        {
            var nums = new[] { 11, 12, 13, 12, 13, 15, 12, 14, 15, 15, 12, 14, 15 };
            //Prints out the standard deviation of the entire data set (population)
            Assert.Equal(1.4366984945013914, nums.StandardDeviation());
        }
    }
}