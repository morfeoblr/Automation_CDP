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
    public class MyltipleOperation
    {
        [TestMethod]
        public void MSTest_SubOperation_Positive1()
        {
            MSTest_SubOperation_Positive(1, -3, 4);
        }
        [TestMethod]
        public void MSTest_SubOperation_Positive2()
        {
            MSTest_SubOperation_Positive(-1, -3, 2);
        }
        [TestMethod]
        public void MSTest_SubOperation_Positive3()
        {
            MSTest_SubOperation_Positive(3, 1, 2);
        }

        private void MSTest_SubOperation_Positive(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Sub(a, b));
        }

        [TestMethod]
        public void MSTest_SubOperation_Negative_Test_Null()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(0, calc.Sub(null, null));
        }

        [TestMethod]
        public void MSTest_SubOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Sub("String", "String");
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
