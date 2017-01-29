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
    public class SqrtOperation
    {
        [TestMethod]
        public void MSTest_SqrtOpertaion_Positive1()
        {
            MSTest_SqrtOpertaion_Positive(16, 4);
        }
        [TestMethod]
        public void MSTest_SqrtOpertaion_Positive2()
        {
            MSTest_SqrtOpertaion_Positive(0, 0);
        }

        private void MSTest_SqrtOpertaion_Positive(double a, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Sqrt(a));
        }

        [TestMethod]
        public void MSTest_SqrtOperation_Negative_Test_Null()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(0, calc.Sqrt(null));
        }

        [TestMethod]
        public void MSTest_SqrtOpertaion_Negative_Test_Minus_Value()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(Double.NaN, calc.Sqrt(-9));
        }

        [TestMethod]
        public void MSTest_SqrtOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Sqrt("String");
                Assert.Fail("There is no exception for String input");
            }
            catch (FormatException ae)
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
