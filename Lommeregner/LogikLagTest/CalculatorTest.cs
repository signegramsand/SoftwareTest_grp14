
using LogikLag;
using NUnit.Framework;

namespace LogicLayerTest
{
    public class Tests
    {
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
            
            
            double testVal = Calculator.add(num1, num2);

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
            
            
            double testVal = Calculator.subtract(num1, num2);

            Assert.That(testVal, Is.EqualTo(sum));
        }

    }
}