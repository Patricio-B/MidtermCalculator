using System;

namespace MidtermCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator class instantiation into a calculator object
            Calculator _calculator = new Calculator();

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

            //user enters num1

            Console.WriteLine("Please enter your second number:");

            //user enters num2

            Console.WriteLine("Result: \n");

            Console.WriteLine("Please select another operation. You could also " +
                "view history by typing 'history'.\n");

            //user selects operation
        }
    }
}
