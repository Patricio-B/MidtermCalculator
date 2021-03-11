using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidtermCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using MidtermCalculator.CalculatorFunctions;


namespace MidtermCalculator.Tests
{ 

    [TestClass()]
    public class CalculatorTests
    {

        [TestMethod()]
        public void CalculatorTest()
        {
            Calculator _calculator = new Calculator();
            Assert.IsInstanceOfType(_calculator, typeof(Calculator));
        }

        [TestMethod()]
        public void SumTest()
        {
            //arrange
            double _a = 1;
            double _b = 2;
            Func<double, double, double> _operation = Operations.Sum;

            Calculator _calculator = new Calculator();

            //act

            _calculator.Create(_a, _b, _operation);

            var _result = _calculator.CreateList();

            //Assert
            Assert.AreEqual(3, _result[0].GetResult());
        }
        [TestMethod()]
        public void CalculatorIntantiationWithParametersTest()
        {
            double _a = 1;
            double _b = 2;
            Func<double, double, double> _operation = Operations.Multiplication;

            Calculator _calculator = new Calculator();

            _calculator.Create(_a, _b, _operation);

            var _result = _calculator.CreateList();

            ;
            Assert.AreEqual(2, _result[0].GetResult());
        }
        [TestMethod()]
        public void CreateCalculationTest()
        {
            double _a = 2;
            double _b = 2;
            Func<double, double, double> _operations = Operations.Division;
            Calculator _calculator = new Calculator();
            _calculator.Create(_a, _b, _operations);
            _operations = Operations.Multiplication;
            _calculator.Create(_a, _b, _operations);

            var _result = _calculator.CreateList();

            Assert.AreEqual(1, _result[0].GetResult());
            Assert.AreEqual(4, _result[1].GetResult());

            //the delegate is run in the foreach
            /* _result.ForEach(delegate (Calculation calculation));
             {
                 Assert.AreEqual(1, _result[0].GetResult());
             }*/

        }

        

        /* [TestMethod()]
         public void CalculateTest()
         {
             double _a = 2;
             double _b = 2;
             Func<double, double, double> _operations = Operations.Division;
             Calculation _calculator = new Calculation();
             _calculator.Calculate(_a, _b, _operations);
             _operations = Operations.Division;
             _calculator.CreateCalculation(_a, _b, _operations);
             Assert.AreEqual(2, _calculator.Calculation[0].GetResult());
             Assert.AreEqual(.5, _calculator.Calculation[1].GetResult());
             Assert.Fail(); */

    }


}