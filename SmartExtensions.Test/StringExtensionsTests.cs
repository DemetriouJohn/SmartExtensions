using System;
using Xunit;

namespace SmartExtensions.Test
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsEmail_NotEmail_False()
        {
            Assert.False("1234".IsEmail());
        }

        [Fact]
        public void IsEmail_Email_True()
        {
            Assert.True("abc@google.com".IsEmail());
        }
    }
}