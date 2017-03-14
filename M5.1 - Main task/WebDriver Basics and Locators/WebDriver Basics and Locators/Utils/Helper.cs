using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Basics_and_Locators.Utils
{
    public class Helper
    {
        public static string ParseByKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
