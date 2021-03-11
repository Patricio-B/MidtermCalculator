using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Events;

namespace MidtermCalculator.Listeners
{
    public class PrintCalculation
    {
        public void OnCalculation(object sender, CalculationEventArgs args)
        {
            Console.WriteLine("Calculation Complete. Result is: " + args.Calculation.GetResult());
        }
    }

}