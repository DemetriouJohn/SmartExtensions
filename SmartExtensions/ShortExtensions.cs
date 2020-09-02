using System;

namespace SmartExtensions
{
    public static class ShortExtensions
    {
        /// <summary>
        ///     Implement Pow by using a for loop when power is a non-zero positive non floating point number
        /// </summary>
        /// <param name="input">double value</param>
        /// <returns>Value of baseNum raised in Pow</returns>
        public static double Pow(this short baseNum, byte power)
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
        public static double Pow(this short baseNum, ushort power)
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
        public static double Pow(this short baseNum, uint power)
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
        public static decimal GetPercentage(this short value, int percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }

        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this short value, float percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }

        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this short value, double percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }

        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal GetPercentage(this short value, long percentOf)
        {
            return (decimal)(value * percentOf / 100);
        }

        /// <summary>
        /// Returns value in KiloBytes
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static int KB(this short value)
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
        public static int MB(this short value)
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
        public static long GB(this short value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return (long)value.MB() * 1024;
        }

        /// <summary>
        /// Terabytes
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long TB(this short value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return value.GB() * (long)1024;
        }
    }
}