using System;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Models;

namespace MidtermCalculator.Events
{
    public abstract class Decorator : ICalculate
    {
        protected ICalculate _calculator;

        public Decorator(ICalculate calculator)
        {
            _calculator = calculator;
        }

        public double CalculateResult(UserInput input)
        {
            throw new NotImplementedException();
        }

        public void DisplayResult(UserInput input)
        {
            throw new NotImplementedException();
        }

        double ICalculate.GetResult()
        {
            throw new NotImplementedException();
        }
    }



    /*{
   protected ICalculate _calculator;

    public Decorator(ICalculate calculator)
    {
        _calculator = calculator;
    }

    public void SetComponent(ICalculate calculator)
    {
        _calculator = calculator;
    }

    // The Decorator delegates all work to the wrapped component.
    //get result ?? it could be static and triggered by an event

    public override string Operation()
    {
        if (this._component != null)
        {
            return this._component.Operation();
        }
        else
        {
            return string.Empty;
        }
    }
}*/
}
