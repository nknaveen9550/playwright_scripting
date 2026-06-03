using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playwright_scripting.pages1
{

    
    public class DemoPage3
    {

        IPage page;

        public DemoPage3(IPage page)

        {
            this.page = page;   
        }

        protected ILocator cart => page.Locator("//a[contains(.,'Add to cart')]");

        protected ILocator Tes => page.Locator("//div[contains(@id,\"more-information\")]/child::p");

        protected ILocator cos => page.Locator("//div[contains(@id,\"tbodyid\")]/child::h3");

        public async Task nk7()
        {

            await cart.ClickAsync();


        }
        public async Task<string> nk8()
        {
            return await Tes.InnerTextAsync();
        }

        public async Task<string> nk9()
        {
          return  await cos.InnerTextAsync();
        }

    }
}
