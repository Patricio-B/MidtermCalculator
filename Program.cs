using System;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Models;
using MidtermCalculator.Events;

namespace MidtermCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            MakeCalculation makeCalculation = new MakeCalculation();

            makeCalculation.Go();



            //Calculator class instantiation into a calculator object
            /*Calculator _calculator = new Calculator();

            ConsoleManager consoleManager = new ConsoleManager();

            EventAggregator eventAggregator = new EventAggregator(_calculator);

            /*var publisher = new Publish();
            var calculationObserver = new Calculation();
            publisher.Attach(calculationObserver);

            var printCalc = new PrintCalculation();
            publisher.Attach(printCalc);

            publisher.PrintCalc();
            publisher.PrintCalc();

            publisher.Detach(printCalc);

            publisher.PrintCalc();*/

            //var _calculation = new ConsoleManager();
            //var _showCalculation = new PrintCalculation();

            /*Console.WriteLine("Welcome to the calculator. You can add, subtract," +
                "multiply, divide, square, and square-root. Please choose which " +
                "functionalities you would like by typing in the number associated " +
                "with it.\n");
            Console.WriteLine(" 1. Addition\n 2. Subtraction\n 3. Multiplication" +
                "\n 4. Division\n 5. Square\n 6. Square Root\n");

            //user enters operation

            Console.WriteLine("Your calculator has the functionality to: \n");

            Console.WriteLine("Which would you like to do first?\n");

            //user selects operation to use

            Console.WriteLine("Please enter your first number:\n");

            var a = ConsoleManager.GetUserNumber();

            Console.WriteLine("Please enter your second number:\n");

            var b = ConsoleManager.GetUserNumber();


            Console.WriteLine("first: " + a + " second: " + b);


            Console.WriteLine("Result: \n");

            //_calculation.GrabCalculation(result);

            Console.WriteLine("Please select another operation. You could also " +
                "view history by typing 'history'.\n");

            //user selects operation 
        }
            public void Calculate(double firstInput, double secondInput, Func<double, double, double> action)
            {

                eventAggregator.AddPrintCalcEvent();
                var _result = _calculator.Create(firstInput, secondInput, action);
                eventAggregator.RemovePrintCalcEvent();


            }*/
        }
    }
}