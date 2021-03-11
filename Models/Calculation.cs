using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.CalculatorFunctions;
using Interfaces;


namespace Models
{
    public class Calculation : ICalculate
    {
        //store 1 value
        public double A { get; set; }
        //store 1 value
        public double B { get; set; }
        //store a single operation function
        public Func<double, double, double> Operation { get; set; }

        /* public List<double> ListOfValues { get; set; }
         //store a bulk operations function
         public Func<List<double>, double> ListOperation { get; set; } */


        //constructor for 3 param (Double, Double, Functi on)
        public Calculation(double a, double b, Func<double, double, double> calculation)
        {
            A = a;
            B = b;
            //this stores the operation to be performed on A and B
            Operation = calculation;
        }
        //constructor for 2 param (list, and function)
        //constructor with 0 param
        public Calculation() { }

        /* public Calculation(List<double> listOfValues, Func<List<double>, double> calculation)
         {
             ListOfValues = listOfValues;

             //this stores the operation to be performed on A and B
             ListOperation = calculation;

         } 

         public static Calculation Create(List<double> listOfValues, Func<List<double>, double> _operation)
         {
             var _calculation = new Calculation(listOfValues, _operation);

             return _calculation;

         } */


        public static Calculation Create(double a, double b, Func<double, double, double> _operation)
        {
            var _calculation = new Calculation(a, b, _operation);

            return _calculation;

        }


        //This calls whatever operation was stored i.e. mult, div, add, sub and returns the answer
        public double GetResult()
        {
            return Operation(A, B);

        }
    }
}
