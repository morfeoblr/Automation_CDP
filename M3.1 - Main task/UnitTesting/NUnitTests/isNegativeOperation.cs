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
    class isNegativeOperation
    {
        [TestCase(1, false)]
        [TestCase(-1, true)]
        [TestCase(0, false)]
        [TestCase(null, false)]
        public void NUnit_isNegativeOperation_Positive(double a, Boolean expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.isNegative(a));
        }

        [Test]
        public void NUnit_isNegativeOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.isNegative("String");
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
