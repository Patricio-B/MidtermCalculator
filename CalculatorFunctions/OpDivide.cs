using System;
using MidtermCalculator.Interfaces;
using System.Collections.Generic;
using System.Text;

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
