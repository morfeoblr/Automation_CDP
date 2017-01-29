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
    public class CosOperation
    {
        [TestMethod]
        public void MSTest_CosOperation_Positive1()
        {
            MSTest_CosOperation_Positive(Math.PI, -1);
        }
        [TestMethod]
        public void MSTest_CosOperation_Positive2()
        {
            MSTest_CosOperation_Positive(0, 1);
        }

        private void MSTest_CosOperation_Positive(double a, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Cos(a));
        }

        [TestMethod]
        public void MSTest_CosOperation_Positive()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(Math.Cos(Math.PI / 6), calc.Cos(Math.PI / 6));
        }

        [TestMethod]
        public void MSTest_CosOperation_Negative_Test_Null()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(1, calc.Cos(null));
        }

        [TestMethod]
        public void MSTest_CosOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Cos("String");
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
