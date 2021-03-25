using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Publisher;

namespace MidtermCalculator.Listeners
{
    public class PrintCalculation : IListen
    { 
        public void Update(IPublish subject)
        { 
            {
                Console.WriteLine("PrintCalculation: Reacted to the event.");
            }
        }
    }

}