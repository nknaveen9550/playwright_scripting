using NUnit.Framework;
using playwright_scripting.Base1;
//using playwright_scripting.Pages;
using playwright_scripting.pages1;
using System.Runtime.InteropServices;

public class Runner : Opening
{
    [Test]
    public async Task Login_To_Application()
    {


        DemoPage1 A1 = new DemoPage1(page);

        A1.nk1();

        await page.WaitForTimeoutAsync(4000);



        A1.nk2("Nknaveen096");
        await page.WaitForTimeoutAsync(2000);

        A1.nk3("nknaveen@123");

        await page.WaitForTimeoutAsync(2000);


        A1.nk4();

        await page.WaitForTimeoutAsync(4000);

        DemoPage2 A2=new DemoPage2(page);

        A2.nk5();


        await page.WaitForTimeoutAsync(8000);

        DemoPage3 A3=new DemoPage3(page);

        A3.nk7();


        await page.WaitForTimeoutAsync(8000);


        A3.nk8();


        string data = await A3.nk8();

        Console.WriteLine(data);

        A3.nk9();

        string data2= await A3.nk9();


        Console.WriteLine(data2);


        Console.WriteLine("Page Has Been Updated Successfully");






    }
}