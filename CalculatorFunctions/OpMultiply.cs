using System;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    class OpMultiply : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Multiplication;
        }
    }
}
