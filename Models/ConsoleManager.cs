using System;
using System.Reflection;
using MidtermCalculator.Models;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Events;
using MidtermCalculator.Listeners;

namespace MidtermCalculator.Models
{
    public class ConsoleManager
    {

        public GetInput getInput = new GetInput();
        public SaveUserInput saveUserInput = new SaveUserInput();

        public ConsoleManager() { }

        public void AddGetInputEvent()
        {
            getInput.UserInput += saveUserInput.OnUserInput;
        }

        public void RemoveGetInputEvent()
        {
            getInput.UserInput -= saveUserInput.OnUserInput;
        }

        public void PrintInput()
        {
            saveUserInput.PrintInputs();
        }

        public double GetUserNumber()
        {
            AddGetInputEvent();
            ConsoleMessages.ConsoleEnterNumber();
            double input = Convert.ToDouble(Console.ReadLine());

            getInput.GetUserInputDigit(input);

            return input;
        }

        public static double GetUserOperation()
        {

            var input = Convert.ToDouble(Console.ReadLine());

            return input;
        }

        public Func<double, double, double> userOperation()
        {
            var getOp = new GetOperation();

            var input = Convert.ToString(GetUserOperation());


            var userOp = getOp.getOperation(input).getOperation();

            return userOp;
        }

    }
}