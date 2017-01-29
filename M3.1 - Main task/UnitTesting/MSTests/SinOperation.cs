using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTests
{
    [TestClass]
    public class SinOperation
    {
        [TestMethod]
        public void MSTest_SinOperation_Positive1()
        {
            MSTest_SinOperation_Positive(Math.PI / 2, 1);
        }
        [TestMethod]
        public void MSTest_SinOperation_Positive2()
        {
            MSTest_SinOperation_Positive(0, 0);
        }

        private void MSTest_SinOperation_Positive(double a, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Sin(a));
        }

        [TestMethod]
        public void MSTest_SinOperation_Positive3()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(Math.Sin(Math.PI / 3), calc.Sin(Math.PI / 3));
        }

        [TestMethod]
        public void MSTest_SinOperation_Negative_Test_Null()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(0, calc.Sin(null));
        }

        [TestMethod]
        public void MSTest_SinOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Sin("String");
                Assert.Fail("There is no exception for String input");
            }
            catch (NotFiniteNumberException ae)
            {
                Assert.AreEqual("Wrong input", ae.Message);
            }
            catch (Exception e)
            {
                Assert.Fail(
                     string.Format("Unexpected exception of type {0} caught: {1}",
                                    e.GetType(), e.Message)
                );
            }
        }
    }
}
