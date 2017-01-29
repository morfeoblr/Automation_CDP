﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTests
{
    [SetUpFixture]
    class BaseTest
    {
        [OneTimeSetUp]
        public void OneceInit()
        {
            Console.WriteLine("Base Init");
        }
        
        [OneTimeTearDown]    
        public void OneceCleanUp()
        {
            Console.WriteLine("Base Cleanup");
        }
    }
  }
