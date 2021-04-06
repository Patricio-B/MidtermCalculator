using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Models;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Events;
using System.Diagnostics;

namespace MidtermCalculator
{
    public class Calculator : ICreate
    {

        public CalculationEvent calculationEvent = new CalculationEvent();

        public Calculation makeCalc(ICreate calculator, double a, double b)
        {
            return new Calculation();
        }


        public Calculator() { }



        public ICalculate Create(double a, double b, Func<double, double, double> operation, ICreate calculator)
        {
            var calculation = new Calculation(a, b, operation);
            calculationEvent.GetCalculation(calculation);
            return calculation;
        }


    }
}
       