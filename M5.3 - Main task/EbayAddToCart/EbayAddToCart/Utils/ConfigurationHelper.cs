using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EbayAddToCart.Utils
{
    class ConfigurationHelper
    {
        public static string GetDriver
        {
            get { return ConfigurationManager.AppSettings["Driver"]; }
            private set { }
        }
        
        public static string GetEnvURL
        {
            get { return ConfigurationManager.AppSettings["Url"]; }
            private set { }
        }
    }
}
