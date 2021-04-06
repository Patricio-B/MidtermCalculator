using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermCalculator.Interfaces
{
    public interface IOperation
    {
        public Func<double, double, double> getOperation();

    }
}
