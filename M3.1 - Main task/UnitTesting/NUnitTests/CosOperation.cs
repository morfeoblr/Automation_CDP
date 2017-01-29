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
    class CosOperation
    {
        [TestCase(Math.PI, -1)]
        [TestCase(0, 1)]
        public void NUnit_CosOperation_Positive(double a, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Cos(a));
        }

        [Test]
        public void NUnit_CosOperation_Positive()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(Math.Cos(Math.PI / 6), calc.Cos(Math.PI / 6));
        }

        [TestCase(null, 1)]
        public void NUnit_CosOperation_Negative_Test_Null(double a, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Cos(a));
        }

        [Test]
        public void NUnit_CosOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Cos("String");
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
