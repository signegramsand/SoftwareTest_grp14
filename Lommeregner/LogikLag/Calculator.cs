﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace LogikLag
{
    public class Calculator
    {
        public double Accumulator { get; private set; }



        public double Add(double a, double b)
        {

            double returnVal = a + b;


            Accumulator = returnVal;

            return (returnVal);
        }

        public double Add(double a)
        {
            double returnVal = a + Accumulator;

            Accumulator = returnVal;

            return returnVal;
        }

        public double Subtract(double a, double b)
        {
            double returnVal = a - b;

            Accumulator = returnVal;


            return (returnVal);
        }

        public double Subtract(double a)
        {
            double returnVal = Accumulator - a ;

            Accumulator = returnVal;

            return returnVal;
        }

        public double Multiply(double a, double b)
        {
            double returnVal = a * b;

            Accumulator = returnVal;

            return (returnVal);
        }

        public double Multiply(double a)
        {
            double returnVal = a * Accumulator;

            Accumulator = returnVal;

            return returnVal;
        }

        public double Divide(double a, double b)
        {
            if (b==0)
            {
                throw new ArgumentException("Can't divide by 0!");
            }

            double returnVal = a / b;
            Accumulator = returnVal;
            return returnVal;
        }

        public double Divide(double a)
        {
            if (a == 0)
            {
                throw new ArgumentException("Can't divide by 0!");
            }

            double returnVal = Accumulator / a;

            Accumulator = returnVal;

            return returnVal;
        }

        public double Power(double x, double exp)
        {

            double returnVal = Math.Pow(x, exp);

            Accumulator = returnVal;


            return (returnVal);
        }

        public void Clear()
        {
            Accumulator = 0;
        }



        public double Power(double exp)
        {
            return Math.Pow(Accumulator, exp);
        }
    }
}
