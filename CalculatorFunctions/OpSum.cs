using System;
using MidtermCalculator.Events;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    public class OpSum : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Sum;
        }
    }
}
