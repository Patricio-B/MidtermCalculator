using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Models;

namespace MidtermCalculator.Interfaces
{

    public interface ICreate
    { 
       public ICalculate Create(double a, double b, Func<double, double, double> _operation);


    }
}

