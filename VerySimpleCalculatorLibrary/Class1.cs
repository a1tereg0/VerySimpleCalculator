using System;

namespace VerySimpleCalculatorLibrary
{
    public static class SimpleCalculator
    {
        static public double add(double value1, double value2)
        {
            return value1 + value2;
        }

        static public double sub(double value1, double value2)
        {
            return value1 - value2;
        }

        static public double mul(double value1, double value2)
        {
            return value1 * value2;
        }

        static public double div(double value1, double value2)
        {
            if (value2 == 0.0)
                throw new DivideByZeroException("Cannot divide by Zero");
            return value1 / value2;
            
        }
    }
}
