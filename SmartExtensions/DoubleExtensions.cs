using System;

namespace SmartExtensions
{
    public static class DoubleExtensions
    {

        /// <summary>
        ///     Using Pow as instance method for simplicity
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Value of baseNum raised in Pow</returns>
        public static double Pow(this double baseNum, double power)
        {
            return Math.Pow(baseNum, power);
        }

        /// <summary>
        ///     Checks if value is NaN
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Returns true if value is NaN, otherwise false </returns>
        public static bool IsNan(this double value)
        {
            return double.IsNaN(value);
        }

        /// <summary>
        ///     Checks if value is infinity
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Returns true if value is infinity, otherwise false </returns>
        public static bool IsInfinity(this double value)
        {
            return double.IsInfinity(value);
        }

        /// <summary>
        ///     Implement Pow by using a for loop when power is a non-zero positive non floating point number
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Value of baseNum raised in Pow</returns>

        public static double Pow(this double baseNum, byte power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        /// <summary>
        ///     Implement Pow by using a for loop when power is a non-zero positive non floating point number
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Value of baseNum raised in Pow</returns>
        public static double Pow(this double baseNum, ushort power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        /// <summary>
        ///     Implement Pow by using a for loop when power is a non-zero positive non floating point number
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Value of baseNum raised in Pow</returns>
        public static double Pow(this double baseNum, uint power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this double value, int percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }

        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this double value, float percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }

        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this double value, double percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this double value, long percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }
    }
}