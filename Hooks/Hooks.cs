using Microsoft.Playwright;
using Reqnroll;

namespace OrangeHRMFramework
{
    [Binding]
    public class Hooks
    {
        public static IPage Page;
        public static IBrowser Browser;

        [BeforeScenario]
        public async Task Setup()
        {
            var playwright = await Playwright.CreateAsync();

            Browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false
                });

            var context = await Browser.NewContextAsync();

            Page = await context.NewPageAsync();
        }

        [AfterScenario]
        public async Task TearDown()
        {
            await Task.Delay(5000);

            await Browser.CloseAsync();
        }
    }
}