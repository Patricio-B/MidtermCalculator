
using System;
using System.Collections.Generic;
using System.Text;
//loading the LINQ functionality
namespace MidtermCalculator.CalculatorFunctions
{
    public class Operations
    {
        public static Func<double, double, double> Sum = (a, b) => a + b;
        public static Func<double, double, double> Subtraction = (a, b) => a - b;
        public static Func<double, double, double> Multiplication = (a, b) => a * b;
        public static Func<double, double, double> Division = (a, b) => a / b;
        //public static Func<double, double, double> Division = (a, b) => (b != 0) ? a / b : throw new DivideByZeroException();
        public static Func<double, double> Square = (a) => Math.Pow(a, 2);
        public static Func<double, double> SquareRoot = (a) => Math.Sqrt(a);
        public static Func<double, double, double> Unassigned = (a, b) => 0;


    }
}
