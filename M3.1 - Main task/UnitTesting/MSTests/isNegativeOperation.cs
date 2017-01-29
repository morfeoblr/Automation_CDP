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
    public class isNegativeOperation
    {
        [TestMethod]
        public void MSTest_isNegativeOperation_Positive1()
        {
            MSTest_isNegativeOperation_Positive(1, false);
        }
        [TestMethod]
        public void MSTest_isNegativeOperation_Positive2()
        {
            MSTest_isNegativeOperation_Positive(-1, true);
        }
        [TestMethod]
        public void MSTest_isNegativeOperation_Positive3()
        {
            MSTest_isNegativeOperation_Positive(0, false);
        }

        private void MSTest_isNegativeOperation_Positive(double a, Boolean expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.isNegative(a));
        }

        [TestMethod]
        public void MSTest_isNegativeOperation_Positive4()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(false, calc.isNegative(null));
        }

        [TestMethod]
        public void MSTest_isNegativeOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.isNegative("String");
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
