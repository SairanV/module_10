using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10.Interface
{
    public interface ICalculatable
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
        double Power(double x, double exponent);
        double SquareRoot(double x);
    }
}
