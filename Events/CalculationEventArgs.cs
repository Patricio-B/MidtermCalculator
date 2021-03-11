using System;
using Interfaces;

namespace MidtermCalculator.Events
{
    public class CalculationEventArgs : EventArgs
    {
        public ICalculate Calculation { get; set; }
    }
}