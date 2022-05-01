using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLommeregner
{
    internal class Calculator
    {
        internal double Add(double x, double y)
        {
            return x + y;
        }
        internal double Subtract(double x, double y)
        {
            return x - y;
        }

        internal double Divide(double x, double y)
        {
            return (double)x / (double)y;
        }

        internal double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
