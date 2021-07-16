using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace SeleniumWebDriverConcept123
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();  //runtime polymorphism - method to be called is resolved during run time based on the object created.
            driver.Url = "https://magento.com/";

            IWebElement signInElement= driver.FindElement(By.Id("gnav_557"));
            signInElement.Click();

            IWebElement emailElement= driver.FindElement(By.Id("email"));
            emailElement.SendKeys("balaji0017@gmail.com");

            driver.FindElement(By.Id("pass")).SendKeys("balaji@12345");

            //click on continue
            driver.FindElement(By.Id("send2")).Click();


            string title=driver.Title;
            Console.WriteLine(title);

           //driver.Quit();

        }
    }
}
