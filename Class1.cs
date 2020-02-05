using System;
namespace Calculator
{
    public class CalculatorClass
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }


        public double Multiply(double a, double b)
        {
            return a * b;
        }


        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }


        public double Add(double addend)
        {
            return Accumulator + addend;
        }

        public double Subtract(double subTractor)
        {
            return Accumulator - subTractor;
        }

        public double Multiply(double multiplier)
        {
            return Accumulator * multiplier;
        }

        public double Divide(double divisor)
        {
            return Accumulator / divisor;
        }

        public double Power(double exponent)
        {
            return Math.Pow(Accumulator, exponent);
        }


        public double Accumulator { get; private set; }

    }
}