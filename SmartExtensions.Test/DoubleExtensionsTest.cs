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


        [Fact]
        public void GetPercentage_Double_Int()
        {
            Assert.Equal(33.0M, ((double)100.0F).GetPercentage((int)33));
        }

        [Fact]
        public void GetPercentage_Double_Float()
        {
            Assert.Equal(33.0M, ((double)100.0F).GetPercentage((float)33.0F));
        }

        [Fact]
        public void GetPercentage_Double_Double()
        {
            Assert.Equal(33.0M, ((double)100.0F).GetPercentage((double)33.0F));
        }

        [Fact]
        public void GetPercentage_Double_Long()
        {
            Assert.Equal(33.0M, ((double)33.0F).GetPercentage((long)100));
        }
    }
}