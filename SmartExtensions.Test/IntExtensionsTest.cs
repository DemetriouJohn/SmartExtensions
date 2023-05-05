using System;
using SmartExtensionMethods;
using Xunit;

namespace SmartExtensions.Test
{
    public class IntExtensionsTest
    {
        [Fact]
        public void Pow_IntBaseBytePow_CorrectResult()
        {
            int baseNum = 129;
            byte pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_IntBaseUShortPow_CorrectResult()
        {
            int baseNum = 129;
            ushort pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_IntBaseIntPow_CorrectResult()
        {
            int baseNum = 129;
            uint pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void GetPercentage_Int_Int()
        {
            Assert.Equal(33.0M, 100.GetPercentage((int)33));
        }

        [Fact]
        public void GetPercentage_Int_Float()
        {
            Assert.Equal(33.0M, 100.GetPercentage((float)33.0F));
        }

        [Fact]
        public void GetPercentage_Int_Double()
        {
            Assert.Equal(33.0M, 100.GetPercentage((double)33.0));
        }

        [Fact]
        public void GetPercentage_Int_Long()
        {
            Assert.Equal(33.0M, 33.GetPercentage((long)100));
        }

        [Fact]
        public void KB_ExpectedResult()
        {
            int v = 33;
            Assert.Equal(33 * 1024, v.KB());
        }

        [Fact]
        public void MB_ExpectedResult()
        {
            int v = 33;
            Assert.Equal(33 * 1024 * 1024, v.MB());
        }

        [Fact]
        public void GB_ExpectedResult()
        {
            int v = 33;
            Assert.Equal((long)33 * 1024 * 1024 * 1024, v.GB());
        }

        [Fact]
        public void TB_ExpectedResult()
        {
            int v = 33;
            Assert.Equal((long)33 * 1024 * 1024 * 1024 * 1024, v.TB());
        }
    }
}