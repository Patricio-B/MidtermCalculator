/*using System;
using System.Collections.Generic;
using MidtermCalculator.Interfaces;
using MidtermCalculator.CalculatorFunctions;

namespace MidtermCalculator.Listeners
{
    public class GetOtherOperations
    {
        Dictionary<string, IOtherOperations> otherOperationIndex = new Dictionary<string, IOtherOperations>();
        private IOtherOperations otherUnassignedOp = new OpUnassigned();

        public GetOtherOperations()
        {
            otherOperationIndex["5"] = new OpSquare();
            otherOperationIndex["6"] = new OpSquareRoot();

            //operationIndex["6"] = new OpSubtraction();
        }

        public IOtherOperations getOtherOperations(string operation)
        {
            if (otherOperationIndex.ContainsKey(operation))
            {
                return otherOperationIndex[operation];
            }
            else
            {
                ConsoleMessages.ConsoleInvalid();
                return otherUnassignedOp;
            }
        }
    }
}*/
