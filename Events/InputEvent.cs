using System;
namespace MidtermCalculator.Events
{
    public class InputEvent : EventArgs
    {
        public double a { get; set; }
        public double b { get; set; }
        public string operation { get; set; }

        public double Result { get; }

        public InputEvent(double _a, double _b, string _operation)
        {
            a = _a;
            b = _b;
            operation = _operation;
        }
    }
}
