using System;
using System.Reflection;
using MidtermCalculator.Models;
using MidtermCalculator.Listeners;
using MidtermCalculator.Publisher;

namespace MidtermCalculator.Models
{
    public class ConsoleManager
    {
        public readonly MethodInfo MethodInfo;
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
        }
    }
}
