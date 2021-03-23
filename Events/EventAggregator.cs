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
            EventHandler handler = operationEvent;
            handler?.Invoke(this, e);
        }

        private void FindOperation(string operation)
        {
            return getOperation(operation);
            // send an event
            //OnOperationEvent(new InputEvent(userOperation));
        }

        private void CreateOperation(object sender, EventArgs e)
        {
            var operation = FindOperation();
            OnOperationEvent(new InputEvent(operation));
        }

        /*public void OnNewOperation(Operation operation)
        {

        }*/
    }
}
