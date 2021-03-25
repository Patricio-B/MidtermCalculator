using System;
namespace MidtermCalculator.Events
{
    public class GetUserInput : EventArgs
    {
        public double UserDigitInput { get; set; }
        public Func<double, double, double> UserOpInput { get; set; }
        public string UserMenuInput { get; set; }

        /*public double a { get; set; }
        public double b { get; set; }
        public string operation { get; set; }

        public double Result { get; }

        public InputEvent(double _a, double _b, string _operation)
        {
            a = _a;
            b = _b;
            operation = _operation;
        }*/
    }
}
