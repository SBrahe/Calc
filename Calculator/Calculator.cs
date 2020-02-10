using System;
using System.Runtime.CompilerServices;

namespace Calculator
{
	public class CalculatorClass
	{
		public double Add(double a, double b)
		{
            Accumulator = a + b;
            return Accumulator;
        }

		public double Subtract(double a, double b)
		{
			Accumulator = a - b;
            return Accumulator;
        }
		public double Multiply(double a, double b)
		{
			Accumulator = a * b;
            return Accumulator;
        }


		public double Power(double x, double exp)
		{
			Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

		public double Divide(double dividend, double divisor)
		{
            
            Accumulator = dividend / divisor;
            return Accumulator;
        }

		public double Add(double addend)
		{
            Accumulator += addend;
            return Accumulator;
        }

		public double Subtract(double subTractor)
		{
            Accumulator -= subTractor;
            return Accumulator;
        }

		public double Multiply(double multiplier)
		{
            Accumulator *= multiplier;
            return Accumulator;
        }

		public double Divide(double divisor)
		{
            
            Accumulator /= divisor;
			
            return Accumulator;
        }

		public double Power(double exponent)
		{
			Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

		public double Accumulator { get; set; }
	}
}