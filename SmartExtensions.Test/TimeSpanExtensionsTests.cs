using System;
using SmartExtensionMethods;
using Xunit;

namespace SmartExtensions.Test
{
    public class TimeSpanExtensionsTests
    {
        [Fact]
        public void FromMilliSeconds_Int_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromMilliseconds(5), 5.Milliseconds());
        }

        [Fact]
        public void FromMilliSeconds_Double_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromMilliseconds(5), 5.0.Milliseconds());
        }

        [Fact]
        public void FromSeconds_Int_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromSeconds(5), 5.Seconds());
        }

        [Fact]
        public void FromSeconds_Double_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromSeconds(5), 5.0.Seconds());
        }

        [Fact]
        public void FromMinutes_Int_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromMinutes(5), 5.Minutes());
        }

        [Fact]
        public void FromMinutes_Double_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromMinutes(5), 5.0.Minutes());
        }

        [Fact]
        public void FromHours_Int_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromHours(5), 5.Hours());
        }

        [Fact]
        public void FromHours_Double_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromHours(5), 5.0.Hours());
        }

        [Fact]
        public void FromDays_Int_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromDays(5), 5.Days());
        }

        [Fact]
        public void FromDays_Double_EqualToOriginal()
        {
            Assert.Equal(TimeSpan.FromDays(5), 5.0.Days());
        }
    }
}