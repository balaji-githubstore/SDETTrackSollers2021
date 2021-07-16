using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace SeleniumWebDriverConcept123
{
    class Demo1
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();  //runtime polymorphism - method to be called is resolved during run time based on the object created.

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //implicit wait =30s

            driver.Url = "https://magento.com/";

            IWebElement signInElement= driver.FindElement(By.Id("gnav_557")); //find the element 500ms
            signInElement.Click();

            IWebElement emailElement= driver.FindElement(By.Id("email"));
            emailElement.SendKeys("balaji0017@gmail.com");

            driver.FindElement(By.Id("pass")).SendKeys("balaji@12345");

            //click on continue
            driver.FindElement(By.Name("send")).Click();

            string title=driver.Title;
            Console.WriteLine(title);

            driver.FindElement(By.LinkText("Log Out")).Click();
            //driver.Quit();

        }
    }
}
