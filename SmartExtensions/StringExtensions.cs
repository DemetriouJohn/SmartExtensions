using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace SmartExtensions
{
    public static class StringExtensions
    {
        public static bool CaseInsensitiveContains(this string first, string second)
        {
            return second.IsNullOrEmpty() || first.IndexOf(second, StringComparison.InvariantCultureIgnoreCase) >= 0;
        }

        public static bool CaseInsensitiveCompare(this string first, string second)
        {
            return string.Compare(first, second, StringComparison.InvariantCultureIgnoreCase) == 0;
        }

        /// <summary>
        ///     Checks if string has value, if not, returns default
        /// </summary>
        /// <param name="input">String input</param>
        /// <param name="@default">default value to return</param>
        /// <returns>Returns original value if not null or empty, otherwise return default value</returns>
        public static string ToValueOrDefault(this string value, string @default)
        {
            return !value.IsNullOrEmpty() ? value : @default;
        }

        /// <summary>
        ///     Checks if string is null or empty
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>Returns true if string is null or empty</returns>
        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        /// <summary>
        ///     Checks if string is null or Whitespace
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>Returns true if string is null or Whitespace</returns>
        public static bool IsNullOrWhitespace(this string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        ///     Returns a new string with all the spaces removed
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>The new string</returns>
        public static string RemoveSpaces(this string value)
        {
            return value.Replace(" ", string.Empty);
        }

        /// <summary>
        ///     Attempts to parse string to Int32. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.Int32 was successful</returns>
        public static bool TryToInt32(this string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        /// <summary>
        ///     Attempts to parse string to Int64. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.Int64 was successful</returns>
        public static bool TryToInt64(this string input, out long result)
        {
            return long.TryParse(input, out result);
        }

        /// <summary>
        ///     Attempts to parse string to Int16. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.Int16 was successful</returns>
        public static bool TryToInt16(this string input, out short result)
        {
            return short.TryParse(input, out result);
        }

        /// <summary>
        ///     Attempts to parse string to DateTime. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.DateTime was successful</returns>
        public static bool TryToDate(this string input, out DateTime result)
        {
            return DateTime.TryParse(input, out result);
        }

        /// <summary>
        ///     Attempts to parse string to Decimal. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.Decimal was successful</returns>
        public static bool TryToDecimal(this string input, out decimal result)
        {
            return decimal.TryParse(input, out result);
        }

        /// <summary>
        ///     Attempts to parse string to Double. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.Decimal was successful</returns>
        public static bool TryToDouble(this string input, out double result)
        {
            return double.TryParse(input, out result);
        }

        /// <summary>
        ///     Reverses a string
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>Returns the reversed string</returns>
        public static string Reverse(this string input)
        {
            if (input.IsNullOrWhitespace())
            {
                return string.Empty;
            }

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        ///     Validates input if it resembles an email
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>Returns true if input resembles email, otherwise false</returns>
        public static bool IsEmail(this string input)
        {
            var match = Regex.Match(input, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
            return match.Success;
        }

        /// <summary>
        ///     Extracts email from a string
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>Returns string email if one exists, or empty string if not</returns>
        public static string ExtractEmail(this string input)
        {
            if (input == null || string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            var match = Regex.Match(input, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
            return match.Success ? match.Value : string.Empty;
        }

        /// <summary>
        ///     Validates input if it resembles a phone number
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>Returns true if input resembles a phone number, otherwise false</returns>
        public static bool IsPhone(this string input)
        {
            var match = Regex.Match(input, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", RegexOptions.IgnoreCase);
            return match.Success;
        }

        /// <summary>
        ///     Checks to see if the given text is a valid palindrome or not.
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>Returns true if input is a palindrome, otherwise false</returns>
        public static bool IsPalindrome(this string input)
        {
            int nLen = input.Length - 1;
            int nHalfLen = nLen / 2;
            for (int i = 0; i < nHalfLen; i++)
            {
                if (input.Substring(i, 1) != input.Substring(nLen - i, 1))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        ///     Check whether the specified string contains an array of strings for each.
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>Returns true if all strings are contained, otherwise false</returns>
        public static bool ContainsAll(this string value, params string[] values)
        {
            foreach (string one in values)
            {
                if (!value.Contains(one))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Joins a list of strings with the provided separator
        /// </summary>
        public static string Join(this IEnumerable<string> values, string separator)
            => string.Join(separator, values);

        /// <summary>
        /// Joins a list of strings with a single space
        /// </summary>
        public static string JoinWithSpace(this IEnumerable<string> values)
            => values.Join(" ");

        /// <summary>
        /// Joins a list of strings with ", "
        /// </summary>
        public static string JoinWithComma(this IEnumerable<string> values)
            => values.Join(", ");

        /// <summary>
        ///     Deserializes string to type &lt;T&gt;.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">String value containing XML</param>
        /// <returns>The desieralized Xml as &lt;T&gt;</returns>
        public static T DeserializeXml<T>(this string value)
        {
            var serializer = new XmlSerializer(typeof(T));
            var reader = new StringReader(value);

            return (T)serializer.Deserialize(reader);
        }

        /// <summary>
        /// Converts Windows and Linux new line characters to HTML break characters
        /// </summary>
        public static string Nl2Br(this string s)
        {
            return s.Replace("\r\n", "<br />").Replace("\n", "<br />");
        }

        /// <summary>
        /// Check that the given string is in a list of potential matches.
        /// </summary>
        public static bool EqualsAny(this string str, params string[] args)
        {
            return args.Any(x => StringComparer.InvariantCultureIgnoreCase.Equals(x, str));
        }

        /// <summary>
        /// Convert string to specific Enumeration Value 
        /// </summary>
        public static T GetEnumValue<T>(this string value, T defaultValue) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new NotSupportedException($"{typeof(T).Name} must be an enumerated type");
            }

            foreach (T item in Enum.GetValues(typeof(T)))
            {
                if (item.ToString().ToLower().Equals(value.Trim().ToLower())) return item;
            }

            return defaultValue;
        }

        /// <summary>
        /// Convert string to CamelCaseRepresentation
        /// </summary>
        public static string ToCamelCase(this string the_string)
        {
            if (the_string == null || the_string.Length < 2)
            {
                return the_string;
            }

            var words = the_string.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

            var result = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                result += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
            }

            return result;
        }
    }
}
