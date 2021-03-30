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
        //private IOperation unassignedMsg = new OpUnassigned();
        private IMessage unassignedMsg = new ConsoleInvalid();

        public showMessage()
        {
            MessageIndex["1"] = new ConsoleWelcome();
            MessageIndex["2"] = new ConsoleOperations();
            MessageIndex["3"] = new ConsoleInvalid();
            MessageIndex["4"] = new ConsoleEnterNumber();
            MessageIndex["5"] = new ConsoleDecision();
        }

        public IMessage displayMessage(string msg)
        {
            if (MessageIndex.ContainsKey(msg))
            {
                return MessageIndex[msg];
            }
            else
            {
                //ConsoleMessages.ConsoleInvalid();
                return unassignedMsg;
            }
        }
    }
}
