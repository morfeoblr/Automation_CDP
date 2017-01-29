using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests
{
    [TestClass]
    public class AddOperation:BaseTest
    {
        [TestMethod]
        public void MSTest_AddOperation_Positive1()
        {
            MSTest_AddOperation_Positive(1,-3,-2);
        }
        [TestMethod]
        public void MSTest_AddOperation_Positive2()
        {
            MSTest_AddOperation_Positive(1,1,2);
        }
        [TestMethod]
        public void MSTest_AddOperation_Positive3()
        {
            MSTest_AddOperation_Positive(-5, -3, -8);
        }

        private void MSTest_AddOperation_Positive(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Add(a, b));
        }

        [TestMethod]
        public void MSTest_AddOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Add("String", "String");
                Assert.Fail("There is no exception for String input");
            }
            catch (InvalidCastException ae)
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

        [TestMethod]
        public void MSTest_AddOperation_Negative_Test_Null()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Add(null, null);
                Assert.Fail("There is no exception for Null input");
            }
            catch (NullReferenceException ae)
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
