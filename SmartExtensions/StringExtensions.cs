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

        public static string ToValueOrDefault(this string value, string @default)
        {
            return !string.IsNullOrEmpty(value) ? value : @default;
        }

        public static bool IsNullOrEmpty(this string first)
        {
            return string.IsNullOrEmpty(first);
        }

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
    }
}
