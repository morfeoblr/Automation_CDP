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
    class AddOperation
    {
        [TestCase(1, -3, -2)]
        [TestCase(1, 1, 2)]
        [TestCase(-5, -3, -8)]
        public void NUnit_AddOperation_Positive(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Add(a, b));
        }

        [Test]
        public void NUnit_AddOperation_Negative_Test_String()
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

        [Test]
        public void NUnit_AddOperation_Negative_Test_Null()
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
