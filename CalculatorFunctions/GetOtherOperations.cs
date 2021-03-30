/*using System;
using System.Collections.Generic;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
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
                Console.WriteLine("You did not enter a valid number associated with an operation. Please enter a number which corresponds to the operation you would like.");
                return otherUnassignedOp;
            }
        }

    }
}*/
