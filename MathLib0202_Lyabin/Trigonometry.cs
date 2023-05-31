using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib0202_Lyabin
{
    public class Trigonometry
    {
        public static double Sin(double angle)
        {
            angle = ConvertToRadians(angle);
            double result = 0;

            double term = angle;
            double numerator = angle;
            double denominator = 1;

            for (int i = 1; i <= 10; i++)
            {
                numerator = -numerator * angle * angle;
                denominator = denominator * (2 * i) * (2 * i + 1);
                term = numerator / denominator;
                result += term;
            }

            return result;
        }

        public static double Cos(double angle)
        {
            angle = ConvertToRadians(angle);
            double result = 0;

            double term = 1;
            double numerator = 1;
            double denominator = 1;

            for (int i = 1; i <= 10; i++)
            {
                numerator = -numerator * angle * angle;
                denominator = denominator * (2 * i - 1) * (2 * i);
                term = numerator / denominator;
                result += term;
            }

            return result;
        }

        public static double Tan(double angle)
        {
            double sin = Sin(angle);
            double cos = Cos(angle);

            if (cos == 0)
            {
                throw new Exception("Невозможно вычислить tg a: деление на ноль");
            }

            return sin / cos;
        }

        public static double Cotan(double angle)
        {
            double tan = Tan(angle);

            if (tan == 0)
            {
                throw new Exception("Невозможно вычислить ctg a: деление на ноль");
            }

            return 1 / tan;
        }

        public static double Arcsin(double number)
        {
            if (number < -1 || number > 1)
            {
                throw new Exception("Невозможно вычислить arcsin a: недопустимый аргумент");
            }

            double result = number;
            double term = number;
            double numerator = number;
            double denominator = 1;
            double factorial = 1;

            for (int i = 1; i <= 10; i++)
            {
                numerator = numerator * number * number * (2 * i - 1) * (2 * i - 1);
                denominator = denominator * (2 * i) * (2 * i + 1);
                factorial = factorial * i;
                term = numerator / (factorial * denominator);
                result += term;
            }

            return ConvertToDegrees(result);
        }

        private static double ConvertToRadians(double degrees)
        {
            return degrees * 3.14 / 180;
        }

        private static double ConvertToDegrees(double radians)
        {
            return radians * 180;

        }
    }
}
