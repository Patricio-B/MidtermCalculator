using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using MidtermCalculator;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.ConsoleMessages
{
    class ConsoleInvalid : IMessage
    {
        public void showMessage()
        {
            Console.WriteLine("You did not enter a valid input. Please enter the appropriate choice for your selection.\n");
        }
    }
}