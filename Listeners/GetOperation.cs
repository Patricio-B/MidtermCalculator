using System;
using System.Collections.Generic;
using MidtermCalculator.Interfaces;
using MidtermCalculator.CalculatorFunctions;

namespace MidtermCalculator.Listeners
{
    public class GetOperation
    {
        Dictionary<string, IOperation> operationIndex = new Dictionary<string, IOperation>();
        //Dictionary<string, IOtherOperations> operationIndex2 = new Dictionary<string, IOtherOperations>();
        private IOperation unassignedOp = new OpUnassigned();

        public GetOperation()
        {
            operationIndex["1"] = new OpSum();
            operationIndex["2"] = new OpSubtraction();
            operationIndex["3"] = new OpMultiply();
            operationIndex["4"] = new OpDivide();
            operationIndex["5"] = new OpSquare();
            operationIndex["6"] = new OpSquareRoot();
        }

        public IOperation getOperation(string operation)
        {
            if (operationIndex.ContainsKey(operation))
            {
                return operationIndex[operation];
            }
            else
            {
                return unassignedOp;
            }
        }
    }
}
