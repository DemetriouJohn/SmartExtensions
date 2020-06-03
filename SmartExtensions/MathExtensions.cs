using System;

namespace SmartExtensions
{
    public static class MathExtensions
    {
        public static double Pow(this short baseNum, byte power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public static double Pow(this short baseNum, ushort power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public static double Pow(this short baseNum, uint power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public static double Pow(this double baseNum, double power)
        {
            return Math.Pow(baseNum, power);
        }
    }
}