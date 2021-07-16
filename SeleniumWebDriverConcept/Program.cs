using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumWebDriverConcept123
{
    class Program
    {
        static void Main22(string[] args)
        {
            IWebDriver driver = new ChromeDriver();  
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
 
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            driver.FindElement(By.XPath("//input[@name='fldLoginUserId']")).SendKeys("admin");

            //click on continue
            driver.FindElement(By.XPath("//img[@alt='continue']")).Click();


            //comeout of frame
            driver.SwitchTo().DefaultContent();
        }
    }
}
