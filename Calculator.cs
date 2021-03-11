﻿using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;

namespace MidtermCalculator
{
    public class Calculator : ICreate
    {
        private CollectCalculation _listCalculations = new CollectCalculation();

        public ICalculate Create(double a, double b, Func<double, double, double> _operation)
        {
            var _calculation = Calculation.Create(a, b, _operation);
            _listCalculations.Add(_calculation);
            return _calculation;
        }

        public ICalculate Create(List<double> listOfValues, Func<List<double>, double> _operation)
        {

            var _calculation = ListCalculation.Create(listOfValues, _operation);
            _listCalculations.Add(_calculation);
            return _calculation;
        }

        public Calculator() { }

        public List<ICalculate> CreateList()
        {
            var result = _listCalculations.Calculations;

            return result;

        }
    }

}
using System;
namespace MidtermCalculator
{
    public class Calculator
    {
        public Calculator()
        {
        }
    }
}
