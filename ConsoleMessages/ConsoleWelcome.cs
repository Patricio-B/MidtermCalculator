using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using MidtermCalculator;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.ConsoleMessages
{
    class ConsoleWelcome : IMessage
     {
        public void showMessage()
        {
            Console.WriteLine("Welcome to the calculator. You can add, subtract," +
             "multiply, divide, square, and square-root. Please choose which " +
             "functionalities you would like by typing in the number associated " +
             "with it.\n");
        }
    }
}
