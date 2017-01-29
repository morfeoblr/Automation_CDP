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
    class MyltipleOperation
    {
        [TestCase(1, -3, 4)]
        [TestCase(-1, -3, 2)]
        [TestCase(3, 1, 2)]
        public void NUnit_SubOperation_Positive(double a, double b, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Sub(a, b));
        }

        [Test]
        public void NUnit_SubOperation_Negative_Test_Null()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(0, calc.Sub(null, null));
        }

        [Test]
        public void NUnit_SubOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Sub("String", "String");
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
