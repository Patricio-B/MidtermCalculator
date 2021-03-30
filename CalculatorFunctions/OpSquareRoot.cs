using System;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    class OpSquareRoot : IOtherOperations
    {
        public Func<double, double> getOtherOperations()
        {
            return OtherOperations.SquareRoot;
        }
    }
}
