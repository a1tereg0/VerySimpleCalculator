using Microsoft.VisualStudio.TestTools.UnitTesting;
using VerySimpleCalculatorLibrary;

namespace VerySimpleCalculatorTests
{
    [TestClass]


    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1, 3)]
        [DataRow(0, 1)]
        [DataRow(6, 9)]
        // Commutative Property: a + b = b + a also, a * b = b * a
        public void AdditionAndMultiplicationIsCommutative(double a, double b)
        {
            double aPlusB = SimpleCalculator.add(a, b);
            double bPlusA = SimpleCalculator.add(b, a);
            double aIntoB = SimpleCalculator.mul(a, b);
            double bIntoA = SimpleCalculator.mul(b, a);
            Assert.AreEqual(aPlusB, bPlusA);
            Assert.AreEqual(aIntoB, bIntoA);
        }
        
        [TestMethod]
        [DataRow(5,0)]
        [DataRow(0,9)]
        // Addititive Identity Property: a + 0 = 0 + a = 0
        public void AdditiveIdentity(double a, double b)
        {
            if (a == 0)
            {
                Assert.AreEqual(b, SimpleCalculator.add(a, b));
            } else if (b == 0)
            {
                Assert.AreEqual(a, SimpleCalculator.add(a, b));
            }
        }

        [TestMethod]
        [DataRow(3,6)]
        [DataRow(5,5)]
        [DataRow(56, 11)]
        // a - b is not equal to b - a, unless both values are the same.
        // a / b is not equal to b / a, unless both values are the same.
        public void SubstractionAndDivisionIsNotCommutative(double a, double b)
        {
            if (a != b)
            {
                Assert.AreEqual(SimpleCalculator.sub(a, b), SimpleCalculator.sub(b, a));
                Assert.AreEqual(SimpleCalculator.div(a, b), SimpleCalculator.div(b, a));
            }
        }

        [TestMethod]
        [DataRow(1, 5)]
        [DataRow(45, 1)]
        // Multiplicative Identity Property: a * 1 = 1 * a = a
        public void MultiplicativeIdentity(double a, double b)
        {
            if (a == 1)
            {
                Assert.AreEqual(b, SimpleCalculator.mul(a, b));
            }
            else if (b == 1)
            {
                Assert.AreEqual(a, SimpleCalculator.mul(a, b));
            }
        }


    }
}
