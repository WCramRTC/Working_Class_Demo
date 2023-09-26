using Microsoft.VisualStudio.TestTools.UnitTesting;
using Working_Class_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_Class_Demo.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        // Arrange
        // Act
        // Assert

        [TestMethod()]
        public void AddTestSuccess()
        {
            // Arrange
            Calculator calc = new Calculator();
            double number1 = 2;
            double number2 = 2;
            double expected = 4;

            // Act
            double outcome = calc.Add(number1, number2);

            // Assert
            Assert.AreEqual(expected, outcome);
            //Assert.Fail();
        }

        [TestMethod()]
        public void AddTestFail()
        {
            // Arrange
            Calculator calc = new Calculator();
            double number1 = 2;
            double number2 = 2;
            double notExpected = 5;

            // Act
            double actual = calc.Add(number1, number2);

            // Assert
            Assert.AreNotEqual(notExpected, actual);

        } // AddTestFail()

        // Multiply Method Tests

        [TestMethod()]
        public void MultiplyTestSuccess()
        {
            // Arrange
            Calculator calc = new Calculator();
            double number1 = 5;
            double number2 = 10;
            double expected = 50;

            // Act
            double outcome = calc.Multiply(number1, number2);

            // Assert
            Assert.AreEqual(expected, outcome);
        }

        [TestMethod()]
        public void MultiplyTestFail()
        {
            // Arrange
            Calculator calc = new Calculator();
            double number1 = 5;
            double number2 = 10;
            double notExpected = 57;

            // Act
            double actual = calc.Multiply(number1, number2);

            // Assert
            Assert.AreNotEqual(notExpected, actual);
        }


    }
}