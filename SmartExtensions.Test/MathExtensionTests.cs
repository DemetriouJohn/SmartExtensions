using System;
using Xunit;

namespace SmartExtensions.Test
{
    public class MathExtensionTests
    {
        [Fact]
        public void Pow_ShortBaseBytePow_CorrectResult()
        {
            short baseNum = 129;
            byte pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_ShortBaseUShortPow_CorrectResult()
        {
            short baseNum = 129;
            ushort pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_ShortBaseUintPow_CorrectResult()
        {
            short baseNum = 129;
            uint pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

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
        public void Pow_IntBaseUintPow_CorrectResult()
        {
            int baseNum = 129;
            uint pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }
    }
}
