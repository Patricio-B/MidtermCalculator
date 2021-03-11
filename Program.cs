using System;
using MidtermCalculator.Events;
using MidtermCalculator.Listeners;
using MidtermCalculator.CalculatorFunctions;

namespace MidtermCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator class instantiation into a calculator object
            Calculator _calculator = new Calculator();

            var _calculation = new CreateCalculationEvent();
            var _showCalculation = new PrintCalculation();

            Func<double, double, double> operation = Operations.Sum;


            Console.WriteLine("Welcome to the calculator. You can add, subtract," +
                "multiply, divide, square, and square-root. Please choose which " +
                "functionalities you would like by typing them in.\n");
            Console.WriteLine("'Addition', 'Subtraction', 'Multiplication', " +
                "'Division', 'Square', 'Square root'\n");

            //user enters operation

            Console.WriteLine("Your calculator has the functionality to: \n");

            Console.WriteLine("Which would you like to do first?\n");

            //user selects operation to use

            Console.WriteLine("Please enter your first number:");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your second number:");

            double num2 = Convert.ToDouble(Console.ReadLine());

            var result = _calculator.Create(num1, num2, operation);

            Console.WriteLine("Result: \n");

            _calculation.GrabCalculation(result);

            Console.WriteLine("Please select another operation. You could also " +
                "view history by typing 'history'.\n");

            //user selects operation
        }
    }
}
