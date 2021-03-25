using System;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    class OpUnassigned : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Unassigned;
        }
    }
}
