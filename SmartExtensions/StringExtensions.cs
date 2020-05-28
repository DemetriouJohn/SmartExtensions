using System;

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
        public static bool IsNullOrEmpty(this string first)
        {
            return string.IsNullOrEmpty(first);
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
        ///     Attemptes to parse string to Int32. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.Int32 was successful</returns>
        public static bool TryToInt32(this string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        /// <summary>
        ///     Attemptes to parse string to Int64. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.Int64 was successful</returns>
        public static bool TryToInt64(this string input, out long result)
        {
            return long.TryParse(input, out result);
        }

        /// <summary>
        ///     Attemptes to parse string to Int16. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.Int16 was successful</returns>
        public static bool TryToInt16(this string input, out short result)
        {
            return short.TryParse(input, out result);
        }

        /// <summary>
        ///     Attemptes to parse string to DateTime. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.DateTime was successful</returns>
        public static bool TryToDate(this string input, out DateTime result)
        {
            return DateTime.TryParse(input, out result);
        }

        /// <summary>
        ///     Attemptes to parse string to Decimal. Returns true if successful and false if not. Result contains the result of parsing
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="result">Where result will be stored</param>
        /// <returns>boolean True False to describe if parsing to System.Decimal was successful</returns>
        public static bool TryToDecimal(this string input, out decimal result)
        {
            return decimal.TryParse(input, out result);
        }
    }
}
