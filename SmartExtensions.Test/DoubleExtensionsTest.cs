using System;
using Xunit;

namespace SmartExtensions.Test
{
    public class DoubleExtensionsTest
    {
        [Fact]
        public void Pow_DoubleBaseBytePow_CorrectResult()
        {
            double baseNum = 129;
            byte pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_DoubleBaseUShortPow_CorrectResult()
        {
            double baseNum = 129;
            ushort pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_DoubleBaseIntPow_CorrectResult()
        {
            double baseNum = 129;
            uint pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void IsNan_Nan_True()
        {
            double x = double.NaN;
            Assert.True(x.IsNan());
        }

        [Fact]
        public void IsNan_NotNan_False()
        {
            double x = 5;
            Assert.False(x.IsNan());
        }

        [Fact]
        public void IsInfinity_PositiveInfinity_True()
        {
            double x = double.PositiveInfinity;
            Assert.True(x.IsInfinity());
        }

        [Fact]
        public void IsInfinity_NegativeInfinity_True()
        {
            double x = double.NegativeInfinity;
            Assert.True(x.IsInfinity());
        }

        [Fact]
        public void IsInfinity_NotInfinity_False()
        {
            double x = 5;
            Assert.False(x.IsInfinity());
        }

    }
}
