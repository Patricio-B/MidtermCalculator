using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using MidtermCalculator;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.ConsoleMessages
{
    public class ConsoleDecision : IMessage
    {
        public void showMessage()
        {
            Console.WriteLine("Would you like to continue with calculation? 1. Yes 2. No \n");
        }
    }
}
