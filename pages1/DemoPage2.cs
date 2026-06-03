using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playwright_scripting.pages1
{
   
    public class DemoPage2
    {

        IPage page;
        public DemoPage2(IPage page)

        {
            this.page = page;
        }


        protected ILocator presss => page.Locator("//a[text()='Nexus 6']");



        public async Task nk5()

        {

            await presss.ClickAsync();


        }
    }
}
