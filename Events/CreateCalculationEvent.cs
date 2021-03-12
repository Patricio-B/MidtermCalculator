using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.Events
{
    public class CreateCalculationEvent<T> : EventArgs
    {

        public T Message { get; private set; }
        public CreateCalculationEvent(T message)
        {
            Message = message;
        }


        /*public event EventHandler<CalculationEventArgs> CalculationCompleted;

        public void GrabCalculation(ICalculate calculation)
        {
            OnCalculation(calculation);
        }

        protected virtual void OnCalculation(ICalculate calculation)
        {
            CalculationCompleted.Invoke(this, new CalculationEventArgs() { Calculation = calculation });
        }*/
    }
}