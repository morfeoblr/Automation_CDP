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
    class PowOperation
    {
        [TestCase(4, -2, 0.0625)]
        [TestCase(2, 5, 32)]
        [TestCase(-5, 3, -125)]
        [TestCase(123, 0, 1)]
        [TestCase(0, 88, 0)]
        public void NUnit_PowOperation_Positive1(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Pow(a, b));
        }
        // as far calculator expect 1st parameter as int all scenarios are failed
        // below are diplicate scenarios with int input only
        // correct variant depends on calculator requirements that are not available

        [TestCase(4, -2, 0.0625)]
        [TestCase(2, 5, 32)]
        [TestCase(-5, 3, -125)]
        [TestCase(123, 0, 1)]
        [TestCase(0, 88, 0)]
        public void NUnit_PowOperation_Positive2(int a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Pow(a, b));
        }

        [Test]
        public void NUnit_PowOperation_Negative_Test_String()
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

        [Test]
        public void NUnit_PowOperation_Negative_Test_Null()
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
