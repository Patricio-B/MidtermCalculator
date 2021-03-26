using System;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Models;
using MidtermCalculator.Listeners;

namespace MidtermCalculator.Events
{
    public class EventAggregator : IEventAggregator
    {
        /* public event EventHandler<InputEvent> operationEvent;

         protected virtual void OnOperationEvent(InputEvent e)
         {
             //EventHandler handler = operationEvent;
             operationEvent?.Invoke(this, e);
         }*/

        Calculator _calculator;
        
        PrintCalculation printCalc = new PrintCalculation();
        
        ConsoleManager consoleManager = new ConsoleManager();
        
        //History history = new History();


        public EventAggregator(Calculator calculator)
        {
            _calculator = calculator;
        }

        void StoreUserInput()
        {
            consoleManager.AddGetInputEvent();
        }

        public void DisplayUserInputs()
        {
            consoleManager.PrintInput();

            consoleManager.RemoveGetInputEvent();
        }

        public void RegisterDisplayCalculationEvent()
        {
            _calculator.calculationEvent.calcComplete += printCalc.OnCalc;

        }

        public void UnregisterDisplayCalculationEvent()
        {
            _calculator.calculationEvent.calcComplete -= printCalc.OnCalc;


        }

       

    }
}
