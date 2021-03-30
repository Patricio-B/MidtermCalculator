using System;
using System.Collections.Generic;
using MidtermCalculator.Interfaces;
using MidtermCalculator.CalculatorFunctions;
using MidtermCalculator.ConsoleMessages;


namespace MidtermCalculator.Listeners
{
    public class showMessage
    {
        Dictionary<string, IMessage> MessageIndex = new Dictionary<string, IMessage>();
        //Dictionary<string, IOtherOperations> operationIndex2 = new Dictionary<string, IOtherOperations>();
        private IOperation unassignedMsg = new OpUnassigned();

        public showMessage()
        {
            MessageIndex["1"] = new ConsoleWelcome();
            MessageIndex["2"] = new OpSubtraction();
            MessageIndex["3"] = new OpMultiply();
            MessageIndex["4"] = new OpDivide();
            MessageIndex["5"] = new OpSquare();
            MessageIndex["6"] = new OpSquareRoot();
        }

        public IMessage displayMessage(string msg)
        {
            if (MessageIndex.ContainsKey(msg))
            {
                return MessageIndex[msg];
            }
            else
            {
                ConsoleMessages.ConsoleInvalid();
                return unassignedMsg;
            }
        }
    }
}
