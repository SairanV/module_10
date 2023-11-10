using module_10.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10.Class
{
    public class SimpleCalculator : ICalculatable
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
                throw new ArgumentException("Невозможно делить на ноль");
        }

        public double Power(double x, double exponent)
        {
            return Math.Pow(x, exponent);
        }

        public double SquareRoot(double x)
        {
            if (x >= 0)
                return Math.Sqrt(x);
            else
                throw new ArgumentException("Невозможно вычислить квадратный корень из отрицательного числа");
        }
    }
}
