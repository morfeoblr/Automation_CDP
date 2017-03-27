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
        public static string GetDriver
        {
            get { return ConfigurationManager.AppSettings["Driver"]; }
            private set { }
        }
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
        public static string GetAuthIDMSAdminUser
        {
            get { return ConfigurationManager.AppSettings["User_auth_id_admin"]; }
            private set { }
        }
        public static string GetAuthIDMSEndUser
        {
            get { return ConfigurationManager.AppSettings["User_auth_id_end_user"]; }
            private set { }
        }
        public static string GetAuthIDQAVendor
        {
            get { return ConfigurationManager.AppSettings["User_auth_id_qavendor"]; }
            private set { }
        }
        public static string GetEnvURL
        {
            get { return ConfigurationManager.AppSettings["Url"]; }
            private set { }
        }
    }
}
