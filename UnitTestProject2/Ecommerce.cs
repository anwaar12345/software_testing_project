using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Selenium_AutoTest_Final_Project
{
    class Ecommerce
    {
        IWebDriver driver = new FirefoxDriver();
        ExcelLib Excel_Sheet = new ExcelLib();


        public void Web_Login(string url)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            driver.Url = url;
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("email")).SendKeys(Excel_Sheet.ExcelSetup(1, 1));
            Thread.Sleep(3000);

            driver.FindElement(By.Id("passwd")).SendKeys(Excel_Sheet.ExcelSetup(1, 2));
            Thread.Sleep(3000);

            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.ClassName("logout")).Click();
            Thread.Sleep(3000);
            
            driver.Quit();
        }
        public void Category(string url)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            driver.Url = url;
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("email")).SendKeys(Excel_Sheet.ExcelSetup(1, 1));
            Thread.Sleep(3000);

            driver.FindElement(By.Id("passwd")).SendKeys(Excel_Sheet.ExcelSetup(1, 2));
            Thread.Sleep(3000);

            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.ClassName("sf-with-ul")).Click();
            Thread.Sleep(3000);

            //js.ExecuteScript("window.scrollBy(0,950);");
            //Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Dresses")).Click();
            Thread.Sleep(3000);

            //js.ExecuteScript("window.scrollBy(0,650);");
            //Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Casual Dresses")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.ClassName("logout")).Click();
            Thread.Sleep(3000);

            driver.Quit();

        }
        public void Purchase(string url)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            driver.Url = url;
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("email")).SendKeys(Excel_Sheet.ExcelSetup(1, 1));
            Thread.Sleep(3000);

            driver.FindElement(By.Id("passwd")).SendKeys(Excel_Sheet.ExcelSetup(1, 2));
            Thread.Sleep(3000);

            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.ClassName("sf-with-ul")).Click();
            Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,950);");
            Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Dresses")).Click();
            Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,650);");
            Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Casual Dresses")).Click();
            Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,750);");
            Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Printed Dress")).Click();
            Thread.Sleep(3000);

            for (int i = 1; i < 1; i++)
            {
                driver.FindElement(By.ClassName("icon-plus")).Click();
                Thread.Sleep(2000);
            }

            var education = driver.FindElement(By.Id("group_1"));
            var selectElement = new SelectElement(education);
            selectElement.SelectByValue("3");

            js.ExecuteScript("window.scrollBy(0,250);");
            Thread.Sleep(3000);

            driver.FindElement(By.XPath(".//button[@class='exclusive added' or @name='Submit']")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Proceed to checkout")).Click();
            Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,350);");
            Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Proceed to checkout")).Click();
            Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,1000);");

            Thread.Sleep(3000);

            driver.FindElement(By.Name("processAddress")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.ClassName("logout")).Click();
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
