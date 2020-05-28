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

        public static bool TryToInt(this string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        public static bool TryToDate(this string input, out DateTime result)
        {
            return DateTime.TryParse(input, out result);
        }
    }
}
