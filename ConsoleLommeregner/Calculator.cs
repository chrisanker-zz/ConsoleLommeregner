﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLommeregner
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Divide(double x, double y)
        {
            return (double)x / (double)y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
