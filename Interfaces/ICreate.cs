using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Models;

namespace MidtermCalculator.Interfaces
{

    public interface ICreate
    {
        Calculation makeCalc(ICreate calculator, double a, double b);
    }
}

