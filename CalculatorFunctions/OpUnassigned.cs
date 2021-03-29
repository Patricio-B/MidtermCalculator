using System;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    class OpUnassigned : IOperation, IOtherOperations
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Unassigned;
        }

        public Func<double, double> getOtherOperations()
        {
            return OtherOperations.Unassigned;
        }
    }
}
