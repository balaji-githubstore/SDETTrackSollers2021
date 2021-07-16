using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumWebDriverConcept123
{
    class Demo2
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();  
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
 
            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";

            //admin
            driver.FindElement(By.CssSelector("#authUser123")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");


            SelectElement select = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            select.SelectByText("English (Indian)");
            //click login

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);


            driver.FindElement(By.XPath("//span[@data-bind='text:fname']")).Click();

            driver.FindElement(By.XPath("//li[text()='Logout']")).Click();

     

            //driver.FindElement(By.XPath("//li[text()='Logout']")).Click(); //present and visible 

        }
    }
}
