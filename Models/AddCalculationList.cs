using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Models
{
    public class AddCalculationList
    {
        public List<ICalculate> Calculations = new List<ICalculate>();
        public void Add(ICalculate calculations)
        {

            Calculations.Add(calculations);


        }
    }
}
