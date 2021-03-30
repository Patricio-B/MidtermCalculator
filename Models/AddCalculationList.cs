using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.Models
{
    public class AddCalculationList
    {
        public List<ICreate> Calculations = new List<ICreate>();

        /*public void Add(ICalculate calculations)
        {
            Calculations.Add(calculations);
        }*/
    }
}
