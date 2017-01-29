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
    class SqrtOperation
    {
        [TestCase(16, 4)]
        [TestCase(0, 0)]
        public void NUnit_SqrtOpertaion_Positive(double a, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Sqrt(a));
        }

        [Test]
        public void NUnit_SqrtOperation_Negative_Test_Null()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(0, calc.Sqrt(null));
        }

        [Test]
        public void NUnit_SqrtOpertaion_Negative_Test_Minus_Value()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(Double.NaN, calc.Sqrt(-9));
        }

        [Test]
        public void NUnit_SqrtOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Sqrt("String");
                Assert.Fail("There is no exception for String input");
            }
            catch (FormatException ae)
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
