using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VerySimpleCalculatorLibrary;

namespace VerySimpleCalculatorTests
{
    [TestClass]


    public class SimpleCalculatorTest
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
                Assert.AreNotEqual(SimpleCalculator.sub(a, b), SimpleCalculator.sub(b, a));
                Assert.AreNotEqual(SimpleCalculator.div(a, b), SimpleCalculator.div(b, a));
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
        
        [TestMethod]
        [DataRow(5)]
        [DataRow(9)]
        [DataRow(0)]
        [DataRow(219384)]
        public void DivisionOfZeroByAnyNumberIsZero(double a)
        {
            if (a != 0)
                Assert.IsTrue(SimpleCalculator.div(0, a) == 0);
        }

        [DataTestMethod]
        [DataRow(5, 0)]
        public void DivisionByZeroIsHandledByException(double a, double b)
        {
            Assert.ThrowsException<DivideByZeroException>(() => SimpleCalculator.div(a, b));
        }

        [DataTestMethod]
        [DataRow(6)]
        // multiplicative inverse of a is 1/a, for 6 it's 1/6 which means 6 * 1/6 = 1
        public void MultiplicativeInverseIsReciprocal(double a)
        {
            Assert.AreEqual(SimpleCalculator.mul(a, 1 / a), 1);
        }

        [TestMethod]
        [DataRow(3,7)]
        [DataRow(1,1)]
        [DataRow(2,5)] // verifying the test doesn't take place
        public void AddingTwoOddNumbersIsEven(int a, int b)
        {
            if(isOdd(a) && isOdd(b))
            {
                Assert.IsTrue(isEven(Convert.ToInt32(SimpleCalculator.add(a,b))));
            }
        }

        [TestMethod]
        public void AddingTwoEvenNumbersIsEven()
        {
            int a = 2;
            int b = 8;
            if (isEven(a) && isEven(b))
            {
                Assert.IsTrue(isEven(Convert.ToInt32(SimpleCalculator.add(a, b))));
            }
        }

        [DataTestMethod]
        [DataRow(3,3)]
        [DataRow(7,15)]
        public void MultiplyingTwoOddNumberResultsInOddNumber(int a, int b)
        {
            if (isOdd(a) && isOdd(b))
            {
                Assert.IsTrue(isOdd(Convert.ToInt32(SimpleCalculator.mul(a, b))));
            }
        }

        public bool isOdd(int number) => number % 2 != 0;

        public bool isEven(int number) => number % 2 == 0;



    }
}
