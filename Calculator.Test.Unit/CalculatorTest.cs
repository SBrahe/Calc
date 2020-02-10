using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private CalculatorClass _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator.CalculatorClass();
        }

        [Test]
        public void Add_OnePlusOne_returnsTwo()
        {
            //Arrange- setup

            //Act 

            //Assert

            Assert.That(_uut.Add(1, 1), Is.EqualTo(2));
        }

        [Test]

        public void Subtract_OneFromTwo_ReturnsOne()
        {
            Assert.That(_uut.Subtract(2, 1), Is.EqualTo(1));
        }

        [Test]
        public void Multiply_TwoTimesTwo_ReturnsFour()
        {
            Assert.That(_uut.Multiply(2, 2), Is.EqualTo(4));
        }

        [Test]

        public void Power_TwoToThePowerOfFour_ReturnsSixteen()
        {
            Assert.That(_uut.Power(2, 4), Is.EqualTo(16));
        }

        [Test]
        public void Divide_Two_And_Two()
        {
            Assert.That(_uut.Divide(2, 2), Is.EqualTo(1));
        }

        [Test]
        public void Divide_Two_And_Zero()
        {
            Assert.That(_uut.Divide(2, 0), Is.EqualTo(double.PositiveInfinity));
        }



        //Accumulator tests:
        [Test]
        public void One_Param_addition_one_two_three()
        {
            _uut.Add(1, 2);
            Assert.That(_uut.Add(3), Is.EqualTo(6));
        }

        [Test]
        public void One_Param_subtraction_10_5_2()
        {
            _uut.Subtract(10, 5);
            Assert.That(_uut.Subtract(2), Is.EqualTo(3));
        }

        [Test]
        public void One_Param_multiplication_5_5_5()
        {
            _uut.Multiply(5, 5);
            Assert.That(_uut.Multiply(5), Is.EqualTo(125));
        }

        [Test]
        public void One_Param_division_40_2_2()
        {
            //_uut.Divide(40, 2);

            
            _uut.Divide(40,2);
            Assert.That(_uut.Divide(2), Is.EqualTo(10));
        }

        [Test]
        public void One_Param_division_divide_by_zero_40_2_0()
        {

            _uut.Divide(40, 2);
            Assert.That(_uut.Divide(0), Is.EqualTo(double.PositiveInfinity));
        }

        [Test]
        public void One_Param_power_2_4_2()
        {
            _uut.Power(2, 4);
            Assert.That(_uut.Power(2),Is.EqualTo(256));
        }

        [Test]
        public void One_Param_power_minus_2_2_3()
        {
            _uut.Power(-2, 2);
            Assert.That(_uut.Power(3), Is.EqualTo(64));
        }

        [Test]
        public void One_Param_power_minus_2_3_3()
        {
           
            _uut.Power(-2, 3);
            Assert.That(_uut.Power(3), Is.EqualTo(-512));
        }

        [Test]
        public void One_Param_power_2_minus_4_2()
        {
            _uut.Power(2, -4);
            Assert.That(_uut.Power(2), Is.EqualTo(0.00390625));
        }

        [Test]
        public void ClearAccumulator()
        {
            _uut.Add(5, 5);
            _uut.Clear();
            Assert.That(_uut.Accumulator,Is.EqualTo(0));
        }

    }
}