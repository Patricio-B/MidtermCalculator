using System;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.Events
{
    public class EventAggregator : IEventAggregator
    {
        public event EventHandler<InputEvent> operationEvent;

        protected virtual void OnOperationEvent(InputEvent e)
        {
            //EventHandler handler = operationEvent;
            operationEvent?.Invoke(this, e);
        }
    }
}
