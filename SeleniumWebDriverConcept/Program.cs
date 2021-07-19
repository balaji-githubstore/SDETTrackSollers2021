using OpenQA.Selenium;
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
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();  
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
 
            driver.Url = "https://www.gotomeeting.com/en-in";

            driver.FindElement(By.XPath("//button[text()='Accept Recommended Settings']")).Click();

            driver.FindElement(By.LinkText("Start for Free")).Click();

            driver.FindElement(By.Id("first-name")).SendKeys("bala");
            driver.FindElement(By.Id("last-name")).SendKeys("dina");
            driver.FindElement(By.Id("login__email")).SendKeys("bala@gmail.com");
            driver.FindElement(By.Id("contact-number")).SendKeys("123323");

            SelectElement selectJob = new SelectElement(driver.FindElement(By.Id("JobTitle")));
            selectJob.SelectByText("Help Desk");

            driver.FindElement(By.XPath("//input[@value='10 - 99']")).Click();
            driver.FindElement(By.XPath("//button[text()='Sign Up']")).Click();


        }
    }
}
