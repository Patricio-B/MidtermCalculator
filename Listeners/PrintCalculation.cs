using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Events;

namespace MidtermCalculator.Listeners
{
    public class PrintCalculation
    { 
        public void OnCalc(object sender, CalculationEventArgs calculationEventArgs)
        { 
            {
                Console.WriteLine("The result of your calculation is: " + calculationEventArgs.Calculation.GetResult());
            }
        }
    }

}