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
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            double[] array = { 2.5, -2.5, 5.0 };
            double expected = 5;
            
            double actual = ArrayCalcs.Sum(array);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AvgTest()
        {
            double[] array = { 3.0, 3.0, 3.0 };
            double expected = 3;

            double actual = ArrayCalcs.Avg(array);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] array = { 2.5, -2.5, 5.0 };
            double expected = -2.5;

            double actual = ArrayCalcs.Min(array);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] array = { 2.5, -2.5, 5.0 };
            double expected = 5;

            double actual = ArrayCalcs.Max(array);

            Assert.AreEqual(expected, actual);
        }
    }
}