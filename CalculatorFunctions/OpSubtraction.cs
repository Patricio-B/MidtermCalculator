using System;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    class OpSubtraction : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Subtraction;
        }
    }
}
