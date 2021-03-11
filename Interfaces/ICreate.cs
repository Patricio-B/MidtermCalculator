using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interfaces
{

    public interface ICreate
    { 
        ICalculate Create(double a, double b, Func<double, double, double> _operation);


    }
}

