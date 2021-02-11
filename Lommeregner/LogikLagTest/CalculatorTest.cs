
using System;
using LogikLag;
using NUnit.Framework;

namespace LogicLayerTest
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            //Arrange
            uut = new Calculator();

        }

        [TestCase(10,10,20)]
        [TestCase(20,10,30)]
        [TestCase(10,20,30)]
        [TestCase(1,1,2)]
        [TestCase(1,0,1)]
        [TestCase(1.5,1,2.5)]
        [TestCase(100,-10,90)]
        [TestCase(15,12,27)]
        public void Add_2Numbers_GivesSum(double num1, double num2,double sum)
        {
            
            
            double testVal = uut.Add(num1, num2);

            Assert.That(testVal, Is.EqualTo(sum));
        }        
        
        [TestCase(10,10,0)]
        [TestCase(20,10,10)]
        [TestCase(10,20,-10)]
        [TestCase(1,1,0)]
        [TestCase(1,0,1)]
        [TestCase(1.5,1,0.5)]
        [TestCase(100,-10,110)]
        [TestCase(15,12,3)]
        public void Subtract_2Numbers_GivesSum(double num1, double num2,double sum)
        {
            
            
            double testVal = uut.Subtract(num1, num2);

            Assert.That(testVal, Is.EqualTo(sum));
        }


        [TestCase(10, 10, 0)]
        [TestCase(20, 10, 10)]
        [TestCase(10, 20, -10)]
        [TestCase(1, 1, 0)]
        [TestCase(1, 0, 1)]
        [TestCase(1.5, 1, 0.5)]
        [TestCase(100, -10, 110)]
        [TestCase(15, 12, 3)]
        public void Accumulator_Subtract_AccululatorSubbed(double num1, double num2, double sum)
        {
            double testVal = uut.Subtract(num1, num2);


            double accum = uut.Accumulator;

            Assert.That(accum , Is.EqualTo(sum));
        }





        [TestCase(10, 10, 1)]
        [TestCase(20, 10, 2)]
        [TestCase(10, 20, 0.5)]
        [TestCase(1, 1, 1)]
        [TestCase(1.5, 1, 1.5)]
        [TestCase(100, -10, -10)]
        [TestCase(15, 10, 1.5)]
        public void Divide_2Numbers_GivesSum(double num1, double num2, double sum)
        {
            double testVal = uut.Divide(num1, num2);
            Assert.That(testVal, Is.EqualTo(sum));
        }



        [Test]
        public void Divide_divide1With0_GiveException()
        {
            Assert.That(() => uut.Divide(1,0), Throws.TypeOf<System.ArgumentException>());
        }


        [TestCase(10, 1, 10)]
        [TestCase(10, 2, 100)]
        [TestCase(2, 2, 4)]
        [TestCase(1, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(-1, 2, 1)]
        [TestCase(15, 3, 3375)]
        public void Power_2Numbers_GivesSum(double num1, double num2, double sum)
        {
            double testVal = uut.Power(num1, num2);

            Assert.That(testVal, Is.EqualTo(sum));
        }


        [TestCase(10000000000, 10000000000)]
        public void Power_2LargeNumbers_GivesOverFlow(double num1, double num2)
        {
            double testVal = uut.Power(num1, num2);

            Assert.That(testVal,Is.EqualTo(double.PositiveInfinity));
        }

        [TestCase(10, 1, 10)]
        [TestCase(10, 2, 20)]
        [TestCase(2, 2, 4)]
        [TestCase(1, 1, 1)]
        [TestCase(1, 0, 0)]
        [TestCase(-1, 2, -2)]
        [TestCase(15, 3, 45)]
        [TestCase(3,4,12)]
        public void Multiply_2Numbers_GivesSum(double num1, double num2, double sum)
        {
            double testVal = uut.Multiply(num1, num2);

            Assert.That(testVal, Is.EqualTo(sum));
        }


        [TestCase(10, 1)]
        [TestCase(10, 2)]
        [TestCase(2, 2)]
        [TestCase(1, 1)]
        [TestCase(-2, -2)]
        [TestCase(-1, 3)]
        [TestCase(0, 0)]
        public void AddOverflow_2Number_GiveSum(double num1, double num2)
        {
            double AccumulatorOnce = uut.Add(num1);

            Assert.That(AccumulatorOnce, Is.EqualTo(num1));
            Assert.That(AccumulatorOnce, Is.EqualTo(uut.Accumulator));



            double AccumulatorTwice = uut.Add(num2);

            Assert.That(AccumulatorTwice, Is.EqualTo(num1+num2));
            Assert.That(AccumulatorTwice, Is.EqualTo(uut.Accumulator));
        }



        [TestCase(10, 1, 10)]
        [TestCase(10,-2, -20)]
        [TestCase(-2, -4, 8)]
        public void Multiply_1Number_GivesSum(double num1, double numToAccumulator, double sum)
        {
            uut.Add(numToAccumulator);

            double testVal = uut.Multiply(num1);

            Assert.That(testVal, Is.EqualTo(sum));
        }

        [TestCase(5, 10, 2)]
        [TestCase(6, 18, 3)]
        [TestCase(2, 4, 2)]
        [TestCase(1, 4, 4)]
        [TestCase(-2, 10, -5)]

            public void Divide_1Number_GivesSum(double num1, double numToAccumulator, double sum)
        {
            uut.Add(numToAccumulator);

            double testVal = uut.Divide(num1);

            Assert.That(testVal, Is.EqualTo(sum));
        }


        [TestCase(0, 4)]
        public void Divide_1Number_GivesSum(double num1, double numToAccumulator)
        {
            uut.Add(numToAccumulator);

            Assert.That(() => uut.Divide(num1), Throws.TypeOf<System.ArgumentException>());

        }

        [TestCase(10)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-2)]
        public void Clear_AddNumber_GiveZero(double num1)
        {
            uut.Add(num1);


            uut.Clear();

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }
}