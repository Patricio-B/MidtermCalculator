using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.Models
{
    public class History
    {
        public List<Calculation> history = new List<Calculation>();

        /*public List<Calculation> CreateList()
        {
            var result = calculations.Calculations;

            return result;
        }*/

        public void Add(ICreate calculations)
        {
            history.Add(calculations);
        }

}