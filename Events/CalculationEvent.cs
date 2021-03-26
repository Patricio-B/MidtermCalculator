using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Models;

namespace MidtermCalculator.Events
{
    public class CalculationEvent
    {
        public event EventHandler<CalculationEventArgs> calcComplete;

        public void GetCalculation(ICalculate calculation)
        {
            OnCalculation(calculation);
        }

        protected virtual void OnCalculation(ICalculate calculation)
        {

            if (calcComplete != null)
                calcComplete(this, new CalculationEventArgs() { Calculation = calculation });
        }
    }
}
