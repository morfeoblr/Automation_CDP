using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Basics_and_Locators.Utils
{
    public class GlobalUser
    {
        public string CompanyID { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public GlobalUser()
        {
            CompanyID = ConfigurationHelper.GetCompanyID;
            UserID = ConfigurationHelper.GetUserID;
            Password = ConfigurationHelper.GetPassword;
        }
        public GlobalUser(string companyID, string userID, string password)
        {
            CompanyID = companyID;
            UserID = userID;
            Password = password;
        }
    }
}
