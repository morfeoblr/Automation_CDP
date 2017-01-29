using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize()]
        public void BaseInit()
        {
            Console.WriteLine("Base Init");
        }

        [TestCleanup()]
        public void BaseCleanup()
        {
            Console.WriteLine("Base Cleanup");
        }
    }
}
