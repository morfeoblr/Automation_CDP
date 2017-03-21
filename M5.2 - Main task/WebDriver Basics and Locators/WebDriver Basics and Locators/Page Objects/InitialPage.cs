using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Basics_and_Locators.Page_Objects
{
    public abstract class InitialPage : BasePage
    {
        public string pagepath { get; protected set; }
        public InitialPage(string path)
        {
            this.pagepath = path;
        }
    }
}
