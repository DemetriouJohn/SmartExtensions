using System;

namespace SmartExtensionMethods
{
    public static class FloatExtensions
    {
        /// <summary>
        ///     Checks if value is NaN
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Returns true if value is NaN, otherwise false </returns>
        public static bool IsNan(this float value)
        {
            return float.IsNaN(value);
        }

        /// <summary>
        ///     Checks if value is infinity
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Returns true if value is infinity, otherwise false </returns>
        public static bool IsInfinity(this float value)
        {
            return float.IsInfinity(value);
        }

        /// <summary>
        ///     Implement Pow by using a for loop when power is a non-zero positive non floating point number
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Value of baseNum raised in Pow</returns>

        public static double Pow(this float baseNum, byte power)
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
        public static double Pow(this float baseNum, ushort power)
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
        public static double Pow(this float baseNum, uint power)
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
        public static decimal GetPercentage(this float value, int percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }

        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this float value, float percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }

        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this float value, double percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this float value, long percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }

        /// <summary>
        /// Returns value in KiloBytes
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static float KB(this float value)
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
        public static float MB(this float value)
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
        public static double GB(this float value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return value.MB() * 1024d;
        }

        /// <summary>
        /// Terabytes
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double TB(this float value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return value.GB() * 1024;
        }
    }
}