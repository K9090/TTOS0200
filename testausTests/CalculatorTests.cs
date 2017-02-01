using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            ///AAA principal
            ///A = Arrange, setup data
            ///A = Act, summon method
            ///A = Assert, confirm outcome
            
            //arrange
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 9;

            //act
            int actual = calc.Add(a, b);

            //assert
            Assert.AreEqual(expected, actual);

            //another test using Add-method

            a = 0;
            b = 1;
            expected = 1;
            actual = calc.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //arrange
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 20;

            //act
            int actual = calc.Multiply(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            //arrange
            Calculator calc = new Calculator();
            int a = 4;
            int b = 2;
            int expected = 2;

            //act
            int actual = calc.Divide(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            //arrange
            Calculator calc = new Calculator();
            int a = 6;
            int b = 5;
            int expected = 1;

            //act
            int actual = calc.Subtract(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}