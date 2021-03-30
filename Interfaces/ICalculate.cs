using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Models;

namespace MidtermCalculator.Interfaces
{
    public interface ICalculate
    {

        public double GetResult();

        public double GetResult(ICalculate calculator);

        List<Calculation> Calculations { get; set; }
        /*public abstract void DisplayResult(UserInput input);
        public abstract double CalculateResult(UserInput input);

         interface ListCalculations
         {
             void ListCalculationMethod();
         }

         public class BulkCalculation : Calculation
         {
             public void ListCalculationMethod()
             {

             }
         } */
    }
}
