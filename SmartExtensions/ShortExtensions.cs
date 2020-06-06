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
    }
}