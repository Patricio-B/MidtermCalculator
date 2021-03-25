using System;
using System.Reflection;
using MidtermCalculator.Models;
using MidtermCalculator.Listeners;
using MidtermCalculator.Publisher;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Events;

namespace MidtermCalculator.Models
{
    public class ConsoleManager
    {
        /*public readonly MethodInfo MethodInfo;
        private readonly CalculatorManager CalculatorManager;
        public readonly WeakReference TargetObjet;
        public readonly bool IsStatic;

        private bool isDisposed;
        public Subscription(Action<Tmessage> action, CalculatorManager calculatorManager)
        {
            MethodInfo = action.Method;
            if (action.Target == null)
                IsStatic = true;
            TargetObjet = new WeakReference(action.Target);
            CalculatorManager = calculatorManager;
        }

        public Action<Tmessage> CreatAction()
        {
            if (TargetObjet.Target != null && TargetObjet.IsAlive)
                return (Action<Tmessage>)Delegate.CreateDelegate(typeof(Action<Tmessage>), TargetObjet.Target, MethodInfo);
            if (this.IsStatic)
                return (Action<Tmessage>)Delegate.CreateDelegate(typeof(Action<Tmessage>), MethodInfo);

            return null;
        }*/

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

        public static double GetUserNumber()
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

        public static double GetUserOperation()
        {
            /*var isValid = false;
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

            return ' ';*/

            var input = Convert.ToDouble(Console.ReadLine());

            return input;
        }

        public Func<double, double, double> userOperation()
        {
            var getOp = new GetOperation();

            var input = Convert.ToString(GetUserOperation());

            var userOperation = getOp.getOperation(input).getOperation();

            return userOperation;
        }
    }
}