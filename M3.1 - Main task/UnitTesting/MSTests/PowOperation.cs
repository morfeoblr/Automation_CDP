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
    public class PowOperation
    {
        [TestMethod]
        public void MSTest_PowOperation_Positive2()
        {
            MSTest_PowOperation_Positive1(4, -2, 0.0625);
        }
        [TestMethod]
        public void MSTest_PowOperation_Positive3()
        {
            MSTest_PowOperation_Positive1(2, 5, 32);
        }
        [TestMethod]
        public void MSTest_PowOperation_Positive4()
        {
            MSTest_PowOperation_Positive1(-5, 3, -125);
        }
        [TestMethod]
        public void MSTest_PowOperation_Positive5()
        {
            MSTest_PowOperation_Positive1(123, 0, 1);
        }
        [TestMethod]
        public void MSTest_PowOperation_Positive6()
        {
            MSTest_PowOperation_Positive1(0, 88, 0);
        }

        private void MSTest_PowOperation_Positive1(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Pow(a, b));
        }
        // as far calculator expect 1st parameter as int all scenarios are failed
        // below are diplicate scenarios with int input only
        // correct variant depends on calculator requirements that are not available

        [TestMethod]
        public void MSTest_PowOperation_Positive8()
        {
            MSTest_PowOperation_Positive7(4, -2, 0.0625);
        }
        [TestMethod]
        public void MSTest_PowOperation_Positive9()
        {
            MSTest_PowOperation_Positive7(2, 5, 32);
        }
        [TestMethod]
        public void MSTest_PowOperation_Positive10()
        {
            MSTest_PowOperation_Positive7(-5, 3, -125);
        }
        [TestMethod]
        public void MSTest_PowOperation_Positive11()
        {
            MSTest_PowOperation_Positive7(123, 0, 1);
        }
        [TestMethod]
        public void MSTest_PowOperation_Positive12()
        {
            MSTest_PowOperation_Positive7(0, 88, 0);
        }

        public void MSTest_PowOperation_Positive7(int a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Pow(a, b));
        }

        [TestMethod]
        public void MSTest_PowOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Pow("String", "String");
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

        [TestMethod]
        public void MSTest_PowOperation_Negative_Test_Null()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Pow(null, null);
                Assert.Fail("There is no exception for Null input");
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
