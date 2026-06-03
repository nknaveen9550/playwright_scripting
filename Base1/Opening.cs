using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playwright_scripting.Base1
{
    public class Opening
    {


        protected IPlaywright playwright;
        protected IBrowser browser;
       
        protected IPage page;

        [SetUp]
        public async Task Setup()
        {
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions { Headless = false });

            page = await browser.NewPageAsync();
            await page.GotoAsync("https://www.demoblaze.com/#");
        }

        [TearDown]
        public async Task TearDown()
        {
            await browser.CloseAsync();
        }
    }
}
