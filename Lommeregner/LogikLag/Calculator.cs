﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogikLag
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return (a + b);
        }

        public double Subtract(double a, double b)
        {
            return (a - b);
        }

        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        public double Divide(double a, double b)
        {
            if (b==0)
            {
                throw new ArgumentException("Can't divide by 0!");
            }
            return a / b;
        }

        public double Power(double x, double exp)
        {
            return (Math.Pow(x, exp));
        }
    }
}
