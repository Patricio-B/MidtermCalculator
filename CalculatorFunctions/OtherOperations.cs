using System;
namespace MidtermCalculator.CalculatorFunctions
{
    class OtherOperations
    {
        public static Func<double, double> Square = (a) => Math.Pow(a, 2);
        public static Func<double, double> SquareRoot = (a) => Math.Sqrt(a);
        public static Func<double, double> Unassigned = (a) => 0;
    }
}
