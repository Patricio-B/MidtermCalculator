using System;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    class OpSquare : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Square;
        }
    }
}
