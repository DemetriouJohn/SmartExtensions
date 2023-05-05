using System;
using SmartExtensionMethods;
using Xunit;

namespace SmartExtensions.Test
{
    public class FloatExtensionsTest
    {
        [Fact]
        public void Pow_FloatBaseBytePow_CorrectResult()
        {
            float baseNum = 129f;
            byte pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_FloatBaseUShortPow_CorrectResult()
        {
            float baseNum = 129f;
            ushort pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_FloatBaseIntPow_CorrectResult()
        {
            float baseNum = 129f;
            uint pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void IsNan_Nan_True()
        {
            float x = float.NaN;
            Assert.True(x.IsNan());
        }

        [Fact]
        public void IsNan_NotNan_False()
        {
            float x = 5;
            Assert.False(x.IsNan());
        }

        [Fact]
        public void IsInfinity_PositiveInfinity_True()
        {
            float x = float.PositiveInfinity;
            Assert.True(x.IsInfinity());
        }

        [Fact]
        public void IsInfinity_NegativeInfinity_True()
        {
            float x = float.NegativeInfinity;
            Assert.True(x.IsInfinity());
        }

        [Fact]
        public void IsInfinity_NotInfinity_False()
        {
            float x = 5;
            Assert.False(x.IsInfinity());
        }


        [Fact]
        public void GetPercentage_Float_Int()
        {
            Assert.Equal(33.0M, 100.0F.GetPercentage((int)33));
        }

        [Fact]
        public void GetPercentage_Float_Float()
        {
            Assert.Equal(33.0M, 100.0F.GetPercentage((float)33.0F));
        }

        [Fact]
        public void GetPercentage_Float_Double()
        {
            Assert.Equal(33.0M, 100.0F.GetPercentage((double)33.0));
        }

        [Fact]
        public void GetPercentage_Float_Long()
        {
            Assert.Equal(33.0M, 33.0F.GetPercentage((long)100));
        }

        [Fact]
        public void KB_ExpectedResult()
        {
            float v = 33;
            Assert.Equal(v * 1024, v.KB());
        }

        [Fact]
        public void MB_ExpectedResult()
        {
            float v = 33;
            Assert.Equal(v * 1024 * 1024, v.MB());
        }

        [Fact]
        public void GB_ExpectedResult()
        {
            float v = 33;
            Assert.Equal((double)v * 1024 * 1024 * 1024, v.GB());
        }

        [Fact]
        public void TB_ExpectedResult()
        {
            float v = 33;
            Assert.Equal((double)v * 1024 * 1024 * 1024 * 1024, v.TB());
        }
    }
}