using System;

namespace SmartExtensions
{
    public static class DoubleExtensions
    {
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
        /// <returns>Returns true if value is infinity, otherwise false </returns>

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
        /// <returns>Returns true if value is infinity, otherwise false </returns>
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
        /// <returns>Returns true if value is infinity, otherwise false </returns>
        public static double Pow(this double baseNum, uint power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}