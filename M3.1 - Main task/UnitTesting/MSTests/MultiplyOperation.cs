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
    public class MyltiplyOperation
    {
        [TestMethod]
        public void MSTest_MyltiplyOperation_Positive1()
        {
            MSTest_MyltiplyOperation_Positive(2, -3, -6);
        }
        [TestMethod]
        public void MSTest_MyltiplyOperation_Positive2()
        {
            MSTest_MyltiplyOperation_Positive(1, 3, 3);
        }
        [TestMethod]
        public void MSTest_MyltiplyOperation_Positive3()
        {
            MSTest_MyltiplyOperation_Positive(10, 0, 0);
        }
        [TestMethod]
        public void MSTest_MyltiplyOperation_Positive4()
        {
            MSTest_MyltiplyOperation_Positive(-5, -4, 20);
        }

        private void MSTest_MyltiplyOperation_Positive(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Multiply(a, b));
        }

        // two tests below can't be included due to calculate Myltiply method
        // that support only double values

        //[TestMethod]
        //public void MSTest_MyltiplyOperation_Negative_Test_String()
        //{
        //    try
        //    {
        //        Calculator calc = new Calculator();
        //                  var actual_Result = calc.Multiply("String", "String");
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
        //public void MSTest_MyltiplyOperation_Negative_Test_Null()
        //{
        //    try
        //    {
        //        Calculator calc = new Calculator();
        //                  var actual_Result = calc.Multiply(null, null);
        //    }
        //    catch (NullReferenceException ae)
        //    {
        //        Assert.AreEqual("Wrong input", ae.Message);
        //        Assert.Fail("There is no exception for Null input");
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
