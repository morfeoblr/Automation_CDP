using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver_Basics_and_Locators.Utils;

namespace WebDriver_Basics_and_Locators.Business_objects
{
    abstract class User
    {
        public User(string vendorName)
        {
            this.VendorName = vendorName;
        }
        public string VendorName { get; protected set; }
        public string AuthID;
        //public abstract void GetCredentials();
    }
    class QAVendorUser : User
    {
        public QAVendorUser()
            : base("QAVendor")
        {
            AuthID = ConfigurationHelper.GetAuthIDQAVendor;
        }
    }
    class MSUser : User
    {
        public MSUser()
            : base("Morgan Stanley")
        {
            AuthID = ConfigurationHelper.GetAuthIDMSEndUser;
        }
    }
    abstract class UserDecorator : User
    {
        protected User user;
        public UserDecorator(string vendorName, User user)
            : base(vendorName)
        {
            this.user = user;
        }
    }
    class ToAdminUser : UserDecorator
    {
        public ToAdminUser(User user)
            : base(user.VendorName + ", Admin user", user)
        {
            AuthID = ConfigurationHelper.GetAuthIDMSAdminUser;
        }
    }
    class ToEndUser : UserDecorator
    {
        public ToEndUser(User user)
            : base(user.VendorName + ", End User", user)
        {
            AuthID = ConfigurationHelper.GetAuthIDMSEndUser;
        }
    }
}
