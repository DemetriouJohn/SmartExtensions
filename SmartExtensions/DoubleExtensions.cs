using System;

namespace SmartExtensionMethods
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

        /// <summary>
        /// Returns value in KiloBytes
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static double KB(this double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return value * 1024;
        }

        /// <summary>
        /// Megabytes
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double MB(this double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return value.KB() * 1024;
        }

        /// <summary>
        /// Gigabytes
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal GB(this double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return (decimal)value.MB() * 1024;
        }

        /// <summary>
        /// Terabytes
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal TB(this double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return value.GB() * 1024;
        }
    }
}