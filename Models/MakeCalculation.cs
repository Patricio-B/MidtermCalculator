using System;
using System.Collections.Generic;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Models;
using MidtermCalculator.Events;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Listeners;

namespace MidtermCalculator.Models
{
   

    public class MakeCalculation
    {

        public static Calculator _calculator = new Calculator();

        ConsoleManager consoleManager = new ConsoleManager();

        EventAggregator eventAggregator = new EventAggregator(_calculator);


        public void Go()
        {
            bool choice = true;

           
            ConsoleMessages.ConsoleWelcome();

            while (choice)
            {
           

                ConsoleMessages.ConsoleOperations();

                var op = consoleManager.userOperation();

               



                double _a = consoleManager.GetUserNumber();

                if (op == Operations.SquareRoot)
                {
                    double _b = 0;
                    Calculate(_a, _b, op, _calculator);
                }
                else
                {
                    if (op == Operations.Square)
                    {

                        double _b = 0;
                        Calculate(_a, _b, op, _calculator);

                    }
                    else
                    {
                        double _b = consoleManager.GetUserNumber();
                        Calculate(_a, _b, op, _calculator);
                    }
                }

   
                choice = Decision();

            }
        }

        public void Calculate(double _a, double _b, Func<double, double, double> action, ICreate calculator)
        {
            eventAggregator.AddPrintCalcEvent();
            var _result = _calculator.Create(_a, _b, action, calculator);
            eventAggregator.RemovePrintCalcEvent();
        }            
        
        bool Decision()
        {
            ConsoleMessages.ConsoleDecision();

            string _decision = Console.ReadLine();
              
             if (_decision == "1")
             {
                return true;
             }

             return false;
        }

        void StoreUserInput()
        {
            consoleManager.AddGetInputEvent();
        }

        public void PrintUserInputs()
        {
            consoleManager.PrintInput();
            consoleManager.RemoveGetInputEvent();
        }
    }

}

