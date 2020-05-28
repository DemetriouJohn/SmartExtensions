using System;
using Xunit;

namespace SmartExtensions.Test
{
    public class MathExtensionTests
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
        public void Pow_DoubleBaseUShortPow_CorrectResult()
        {
            double baseNum = 129;
            uint pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }
    }
}
