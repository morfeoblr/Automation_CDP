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
    public class AbsOperation : BaseTest
    {
        [TestMethod]
        public void MSTest_AddOperation_Positive1()
        {
            MSTest_AbsOperation_Positive(4, 4);
        }
        [TestMethod]
        public void MSTest_AddOperation_Positive2()
        {
            MSTest_AbsOperation_Positive(-2, 2);
        }
        [TestMethod]
        public void MSTest_AddOperation_Positive3()
        {
            MSTest_AbsOperation_Positive(0, 0);
        }

        private void MSTest_AbsOperation_Positive(double a, double expected_Result)
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected_Result, calc.Abs(a));
        }

        [TestMethod]
        public void MSTest_AddOperation_Negative_Test_Null()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(0, calc.Abs(null));
        }

        [TestMethod]
        public void MSTest_AbsOperation_Negative_Test_String()
        {
            try
            {
                Calculator calc = new Calculator();
                var actual_Result = calc.Abs("String");
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
