using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Basics_and_Locators.Utils
{
    public static class ConfigurationHelper
    {
        public static string GetCompanyID
        {
            get { return ConfigurationManager.AppSettings["CompanyID"]; }
            private set { }
        }
        public static string GetUserID
        {
            get { return ConfigurationManager.AppSettings["User_ID"]; }
            private set { }
        }
        public static string GetPassword
        {
            get { return ConfigurationManager.AppSettings["Password"]; }
            private set { }
        }
        public static string GetAuthID
        {
            get { return ConfigurationManager.AppSettings["User_auth_id"]; }
            private set { }
        }
        public static string GetEnvURL
        {
            get { return ConfigurationManager.AppSettings["Url"]; }
            private set { }
        }
    }
}
