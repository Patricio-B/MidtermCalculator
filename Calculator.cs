using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Models;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Events;

namespace MidtermCalculator
{
    public class Calculator
    {
        /* public CalculatorManager _calcManager = new CalculatorManager();

         private static Calculator _instance;
         Calculator() { }
         public static Calculator GetInstance()
         {
             if (_instance == null)
             {
                 _instance = new Calculator();
             }

             return _instance;

         }*/

        //public CalculatorBuilder _calculatorBuilder = new CalculatorBuilder();
        public CalculationEvent calculationEvent = new CalculationEvent();

        private ICreate _calculator;
        //public CalculatorManager calculatorManager = new CalculatorManager();


        public Calculator() { }

        public Calculator(ICreate calculator)
        {
            _calculator = calculator;
        }

        public ICalculate Create(double a, double b, Func<double, double, double> operation)
        {
            var calculation = _calculator.Create(a, b, operation);
            calculationEvent.GetCalculation(calculation);
            return calculation;
        }

        public void SwapCalc(ICreate calculator)
        {
            _calculator = calculator;
        }

    }
}
       