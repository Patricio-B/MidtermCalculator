using System;
namespace MidtermCalculator.Events
{
    public class InputEvent : EventArgs
    {
        public double UserInput { get; set; }

        public Func<double, double, double> UserCalculation { get; set; }
    }
}
