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
    class MyltiplyOperation
    {
        [TestCase(2, -3, -6)]
        [TestCase(1, 3, 3)]
        [TestCase(10, 0, 0)]
        [TestCase(-5, -4, 20)]
        public void NUnit_MyltiplyOperation_Positive(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Multiply(a, b));
        }

        // two tests below can't be included due to calculate Myltiply method
        // that support only double values

        //[Test]
        //public void NUnit_MyltiplyOperation_Negative_Test_String()
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

        //[Test]
        //public void NUnit_MyltiplyOperation_Negative_Test_Null()
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
