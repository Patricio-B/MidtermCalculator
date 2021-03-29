using System;
using System.Collections.Generic;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    public class GetOperation
    {
        Dictionary<string, IOperation> operationIndex = new Dictionary<string, IOperation>();
        Dictionary<string, IOtherOperations> operationIndex2 = new Dictionary<string, IOtherOperations>();
        private IOperation unassignedOp = new OpUnassigned();

        public GetOperation()
        {
            operationIndex["1"] = new OpSum();
            operationIndex["2"] = new OpSubtraction();
            operationIndex["3"] = new OpMultiply();
            operationIndex["4"] = new OpDivide();
            operationIndex2["5"] = new OpSquare();
            operationIndex2["6"] = new OpSquareRoot();
        }

        public IOperation getOperation(string operation)
        {
            if (operationIndex.ContainsKey(operation))
            {
                return operationIndex[operation];
            }
            else
            {
                Console.WriteLine("You did not enter a valid number associated with an operation. Please enter a number which corresponds to the operation you would like.");
                return unassignedOp;
            }
        }

    }
}
