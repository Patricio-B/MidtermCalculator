using System;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    class OpSquare : IOtherOperations
    {
        public Func<double, double> getOtherOperations()
        {
            return OtherOperations.Square;
        }
    }
}
