using System;
using MidtermCalculator.Events;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    public class Addition : Decorator
    {
        public Addition (ICalculate calculator) : base(calculator) { }

        public double Add(double a, double b) => a + b;
    }
}
