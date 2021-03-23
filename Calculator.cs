﻿using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Models;
using MidtermCalculator.Interfaces;


namespace MidtermCalculator
{
    public class Calculator : ICreate
    {
        private AddCalculationList _listCalculations = new AddCalculationList();

        //create new event here

        private ICreate _calculator;

        public ICalculate Create(double a, double b, Func<double, double, double> _operation)
        {
            var _calculation = Calculation.Create(a, b, _operation);
            _listCalculations.Add(_calculation);
            return _calculation;
        }

        public Calculator() { }

        public Calculator(ICreate calculator)
        {
            _calculator = calculator;
        }

        public List<ICalculate> CreateList()
        {
            var result = _listCalculations.Calculations;

            return result;

        }
    }

}
