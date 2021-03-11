using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Models;

namespace CalculatorProject.Interfaces
{

    public interface ICreate
    {
        ICalculate Create(List<double> listOfValues, Func<List<double>, double> _operation);
        ICalculate Create(double a, double b, Func<double, double, double> _operation);


    }
}

