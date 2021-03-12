using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Events;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Publisher;

namespace MidtermCalculator.Listeners
{
    public class PrintCalculation : IListen
    {
        public void OnCalculation(object sender, CalculationEventArgs args)
        {
            //Console.WriteLine("Calculation Complete. Result is: " + args.Calculation.GetResult());
        }


        public void Update(IPublish subject)
        {
          
            {
                Console.WriteLine("PrintCalculation: Reacted to the event.");
            }
        }
    }

}