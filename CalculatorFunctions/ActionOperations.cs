using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    public class OpSum : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Sum;

        }
    }
    class OpSubtraction  : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Subtraction;

        }
    }
    class OpMultiply : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Multiplication;

        }
    }
    class OpDivide : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Division;

        }
    }
}
