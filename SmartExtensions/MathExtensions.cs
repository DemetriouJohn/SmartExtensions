using System;

namespace SmartExtensions
{
    public static class MathExtensions
    {
        public static double Pow(this double baseNum, byte power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public static double Pow(this double baseNum, ushort power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

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