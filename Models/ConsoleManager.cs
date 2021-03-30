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

            /*if (input == "5" || "6")
                var input = Convert.ToString(GetUserOperation());
                var userOp = getOp.getOtherOperations(input).getOtherOperations();*/

            var userOp = getOp.getOperation(input).getOperation();

            return userOp;
        }

        /*public Func<double, double> userOperations()
        {
            var getOp = new GetOtherOperations();

            var input = Convert.ToString(GetUserOperation());

            var userOp = getOp.getOtherOperations(input).getOtherOperations();

            return userOp;
        }*/
    }
}