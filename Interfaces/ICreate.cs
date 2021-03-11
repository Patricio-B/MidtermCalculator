using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interfaces
{

    public interface ICreate
    {
        ICalculate Create(List<double> listOfValues, Func<List<double>, double> _operation);
        ICalculate Create(double a, double b, Func<double, double, double> _operation);


    }
}

