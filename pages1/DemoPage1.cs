using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playwright_scripting.pages1
{
    public class DemoPage1
    {



        IPage page;
        public DemoPage1(IPage page)
        {


            this.page = page;
        }


        protected ILocator Log => page.Locator("//a[@id=\"login2\"]");
        protected ILocator Fill1 => page.Locator("//input[@id=\"loginusername\"]");

        protected ILocator Fill2 => page.Locator("//input[@id=\"loginpassword\"]");

        protected ILocator cl => page.Locator("//button[text()='Log in']");

        public async Task nk1()
        {

            await Log.ClickAsync();
        }

        public async Task nk2( string User)
        {

            await Fill1.TypeAsync(User);
        }

        public async Task nk3(string Pass)
        {

            await Fill2.TypeAsync(Pass);
        }

        public async Task nk4()
        {

            await cl.ClickAsync();
        
        }
    }
}
