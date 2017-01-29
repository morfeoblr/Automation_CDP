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
    public class DivideOperation
    {
        [TestMethod]
        public void MSTest_DivideOperation_Positive1()
        {
            MSTest_DivideOperation_Positive(6, -3, -2);
        }
        [TestMethod]
        public void MSTest_DivideOperation_Positive2()
        {
            MSTest_DivideOperation_Positive(8, 4, 2);
        }
        [TestMethod]
        public void MSTest_DivideOperation_Positive3()
        {
            MSTest_DivideOperation_Positive(0, -10, 0);
        }
        [TestMethod]
        public void MSTest_DivideOperation_Positive4()
        {
            MSTest_DivideOperation_Positive(-50, -5, 10);
        }

        private void MSTest_DivideOperation_Positive(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Divide(a, b));
        }

        [TestMethod]
        public void MSTest_DivideOperation_Negative_Divide_by_zero()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(Double.PositiveInfinity, calc.Divide(10, 0));
        }

        // two tests below can't be included due to calculate Divide method
        // that support only double values

        //[TestMethod]
        //public void MSTest_DivideOperation_Negative_Test_String()
        //{
        //    try
        //    {
        //        Calculator calc = new Calculator();
        //                  var actual_Result = calc.Divide("String", "String");
        //                  Assert.Fail("There is no exception for String input");
        //    }
        //    catch (InvalidCastException ae)
        //    {
        //        Assert.AreEqual("Wrong input", ae.Message);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.Fail(
        //             string.Format("Unexpected exception of type {0} caught: {1}",
        //                            e.GetType(), e.Message)
        //        );
        //    }
        //}

        //[TestMethod]
        //public void MSTest_DivideOperation_Negative_Test_Null()
        //{
        //    try
        //    {
        //        Calculator calc = new Calculator();
        //                  var actual_Result = calc.Divide(null, null);
        //                  Assert.Fail("There is no exception for Null input");
        //    }
        //    catch (NullReferenceException ae)
        //    {
        //        Assert.AreEqual("Wrong input", ae.Message);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.Fail(
        //             string.Format("Unexpected exception of type {0} caught: {1}",
        //                            e.GetType(), e.Message)
        //        );
        //    }
        //}
    }
}
