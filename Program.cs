using System;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Models;
using MidtermCalculator.Events;

namespace MidtermCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            MakeCalculation makeCalculation = new MakeCalculation();

            makeCalculation.Go();

        }
    }
}