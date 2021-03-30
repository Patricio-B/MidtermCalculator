using System;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Models;
using MidtermCalculator.Listeners;

namespace MidtermCalculator.Events
{
    public class EventAggregator
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

        showMessage showMsg = new showMessage();

        //History history = new History();


        public EventAggregator(Calculator calculator)
        {
            _calculator = calculator;
        }

        void StoreUserInput()
        {
            consoleManager.AddGetInputEvent();
            //consoleMessages.ConsoleEnterNumber();
            showMsg.displayMessage("4");
        }

        public void DisplayUserInputs()
        {
            Console.WriteLine("Hi display");
            consoleManager.PrintInput();

            consoleManager.RemoveGetInputEvent();
        }

        public void AddPrintCalcEvent()
        {
            _calculator.calculationEvent.calcComplete += printCalc.OnCalc;
  
        }

        public void RemovePrintCalcEvent()
        {
            Console.WriteLine("bye print calc");
            _calculator.calculationEvent.calcComplete -= printCalc.OnCalc;
            DisplayUserInputs();

        }

       

    }
}
