using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using MidtermCalculator;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.ConsoleMessages
{
    class ConsoleEnterNumber : IMessage
    {
        public void showMessage()
        {
            Console.WriteLine("Please enter a number: " + "\n");
        }
    }
}
