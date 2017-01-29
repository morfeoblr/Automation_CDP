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
    class SinOperation
    {
        [TestCase(Math.PI/2, 1)]
        [TestCase(0, 0)]
        public void NUnit_SinOperation_Positive(double a, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Sin(a));
        }

        [Test]
        public void NUnit_SinOperation_Positive()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(Math.Sin(Math.PI / 3), calc.Sin(Math.PI / 3));
        }

        [TestCase(null, 0)]
        public void NUnit_SinOperation_Negative_Test_Null(double a, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Sin(a));
        }

        [Test]
        public void NUnit_SinOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Sin("String");
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
