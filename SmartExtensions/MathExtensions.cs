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

        public static double Pow(this float baseNum, byte power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public static double Pow(this float baseNum, ushort power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public static double Pow(this float baseNum, uint power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public static double Pow(this int baseNum, byte power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public static double Pow(this int baseNum, ushort power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        public static double Pow(this int baseNum, uint power)
        {
            double result = 1;
            for (var i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }

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