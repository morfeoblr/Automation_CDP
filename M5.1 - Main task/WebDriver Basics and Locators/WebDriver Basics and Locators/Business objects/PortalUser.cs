using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Basics_and_Locators.Utils
{
    public class PortalUser
    {
        public string AuthID { get; set; }
        public PortalUser()
        {
            AuthID = ConfigurationHelper.GetAuthID;
        }
    }
}
