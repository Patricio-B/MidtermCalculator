using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace MidtermCalculator.Events
{
    public class CreateCalculationEvent
    {
        public event EventHandler<CalculationEventArgs> CalculationCompleted;

        public void GrabCalculation(ICalculate calculation)
        {
            OnCalculation(calculation);
        }
        
        protected virtual void OnCalculation(ICalculate calculation)
        {
            //CalculationCompleted.Invoke(this, new CalculationEventArgs() { Calculation = calculation });
        }
    }
}