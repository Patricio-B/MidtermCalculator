using System;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    class OpDivide : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Division;
        }
    }
}
