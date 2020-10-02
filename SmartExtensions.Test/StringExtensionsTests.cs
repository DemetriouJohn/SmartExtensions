using SmartExtensions.Tests.Helper;
using System;
using System.Collections.Generic;
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

        [Fact]
        public void Reverse_ExpectedResult()
        {
            Assert.Equal("moc.elgoog@cba", "abc@google.com".Reverse());
        }

        [Fact]
        public void OsPhone_ValidNumberPrefixedPlus_True()
        {
            Assert.True("+1234".IsPhone());
        }

        [Fact]
        public void IsPhone_ValidNumberPrefixedTwoPlus_False()
        {
            Assert.False("++1234".IsPhone());
        }

        [Fact]
        public void IsPallindrome_ValidPalindrome_True()
        {
            Assert.True("asdsa".IsPalindrome());
        }

        [Fact]
        public void IsPallindrome_InValidPalindrome_False()
        {
            Assert.False("bsdsa".IsPalindrome());
        }

        [Fact]
        public void ContainsAll_AllContained_True()
        {
            string value = "John from Cyprus";
            var values = new[] { "John", "Cyprus" };
            Assert.True(value.ContainsAll(values));
        }

        [Fact]
        public void ContainsAll_NotAllContained_False()
        {
            string value = "John from Cyprus";
            var values = new[] { "John", "Greece" };
            Assert.False(value.ContainsAll(values));
        }

        [Fact]
        public void ExtractEmail_containsEmail_Email()
        {
            Assert.Equal("email@email.com", "name,+86738238;email@email.com;address".ExtractEmail());
        }

        [Fact]
        public void ExtractEmail_noEmail_empty()
        {
            Assert.Equal("", "just some text".ExtractEmail());
        }

        [Fact]
        public void ExtractEmail_Email_Email()
        {
            Assert.Equal("abc@abc.com", "abc@abc.com".ExtractEmail());
        }

        [Fact]
        public void Join_IEnumerableStrigns_CorrectResult()
        {
            var list = new List<string>();
            list.Add("a");
            list.Add("bas");
            list.Add("cd");
            var separator = ",";
            Assert.Equal(string.Join(separator, list), list.Join(separator));
        }

        [Fact]
        public void DeserializeXml_ComplexObjectFromMicrosoftDocs_ExpectedResult()
        {
            string value = "<PurchaseOrder><MyAddress><FirstName>George</FirstName></MyAddress></PurchaseOrder>";

            var purchaseOrder = value.DeserializeXml<PurchaseOrder>();

            Assert.Equal("George", purchaseOrder.MyAddress.FirstName);
        }

        [Fact]
        public void Nl2Br_StringWithNewLines_StringHtmlBreaks()
        {
            string s = "line1\r\nline2";
            Assert.Equal("line1<br />line2", s.Nl2Br());
        }

        [Fact]
        public void EqualsAny_StringInsideParams_True()
        {
            string value = "foo";
            Assert.True(value.EqualsAny("bar", "baz", "FOO"));
        }

        [Fact]
        public void GetEnumValue_EnumValue_ExpectedResult()
        {
            Assert.Equal(DayOfWeek.Sunday, "Sunday".GetEnumValue(DayOfWeek.Monday));
        }

        [Fact]
        public void ToCamelCase_TestString_SpacesRemovedConvertedToCamelCase()
        {
            Assert.Equal("thisIsTestString", "this is Test String".ToCamelCase());
        }
    }
}