using System;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    class OpSquareRoot : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.SquareRoot;
        }
    }
}
