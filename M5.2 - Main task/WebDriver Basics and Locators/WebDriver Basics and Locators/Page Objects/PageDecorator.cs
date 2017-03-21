using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Basics_and_Locators.Page_Objects
{
    public class PageDecorator: InitialPage
    {
        protected InitialPage initialpage;
        public PageDecorator(string path, InitialPage initialpage) : base(path)
        {
            this.initialpage = initialpage;
        }
    }
}
