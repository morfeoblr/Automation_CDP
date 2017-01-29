using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTests
{
    [TestFixture]
    class DivideOperation
    {
        [TestCase(6, -3, -2)]
        [TestCase(8, 4, 2)]
        [TestCase(0, -10, 0)]
        [TestCase(-50, -5, 10)]
        public void NUnit_DivideOperation_Positive(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Divide(a, b));
        }

        [TestCase(10, 0, Double.PositiveInfinity)]
        public void NUnit_DivideOperation_Negative_Divide_by_zero(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Divide(a, b));
        }

        // two tests below can't be included due to calculate Divide method
        // that support only double values

        //[Test]
        //public void NUnit_DivideOperation_Negative_Test_String()
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

        //[Test]
        //public void NUnit_DivideOperation_Negative_Test_Null()
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
