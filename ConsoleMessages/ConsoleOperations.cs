using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using MidtermCalculator;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.ConsoleMessages
{
    class ConsoleOperations : IMessage
    {
        public void showMessage()
        {
            Console.WriteLine(" 1. Addition\n 2. Subtraction\n 3. Multiplication" +
                "\n 4. Division\n 5. Square\n 6. Square Root\n");
        }
    }
}
