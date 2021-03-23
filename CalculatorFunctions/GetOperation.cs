using System;
using System.Collections.Generic;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.CalculatorFunctions
{
    public class GetOperation : IOperation
    {
        Dictionary<string, IOperation> operationIndex = new Dictionary<string, IOperation>();

        public GetOperation()
        {
            operationIndex["1"] = new OpSum();
            operationIndex["2"] = new OpSubtraction();
            operationIndex["3"] = new OpMultiply();
            operationIndex["4"] = new OpDivide();
        }

        public IOperation getOperation(string operation)
        {
            return operationIndex[operation];
        }

    }
}
