using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Basics_and_Locators.Utils
{
    public sealed class GlobalUser // used Singleton
    {
        private static readonly GlobalUser user = new GlobalUser();
        static GlobalUser()
        {
        }
        private GlobalUser()
        {
            CompanyID = ConfigurationHelper.GetCompanyID;
            UserID = ConfigurationHelper.GetUserID;
            Password = ConfigurationHelper.GetPassword;
        }
        public static GlobalUser getUser
        {
            get
                {
                    return user;
                }
        }

        public string CompanyID { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }

        //public GlobalUser(string companyID, string userID, string password)
        //{
        //    CompanyID = companyID;
        //    UserID = userID;
        //    Password = password;
        //}
    }
}
