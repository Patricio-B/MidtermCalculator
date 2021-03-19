using System;
using System.Collections;
using System.Collections.Generic;
using MidtermCalculator.Publisher;
using MidtermCalculator.Listeners;

namespace MidtermCalculator.Models
{
    public class CalculatorManager
    {
        public CalculatorManager()
        {
        }
            public static double GetNumber()
            {
                /*var isValid = false;
                while (!isValid)
                {
                    Console.Write(message);
                    var input = Console.ReadLine();
                    isValid = double.TryParse(input, out var number);
                    if (isValid)
                        return number;

                    Console.WriteLine("Please enter a valid number. Press ^C to quit.");
                }*/

                var input = Convert.ToDouble(Console.ReadLine());

                //notify print calculation

                return input;
            }

            private static char GetOperator()
            {
                var isValid = false;
                while (!isValid)
                {
                    Console.Write("Please type the operator (/*+-) > ");
                    var input = Console.ReadKey();
                    Console.WriteLine();
                    var operation = input.KeyChar;
                    if ("/*+-".Contains(operation))
                    {
                        isValid = true;
                        return operation;
                    }

                    Console.WriteLine("Please enter a valid operator (/, *, +, or -). " +
                                      "Press ^C to quit.");
                }

                return ' ';
            }
    }
}
