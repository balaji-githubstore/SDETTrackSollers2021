using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNunitConcept
{
    class WebTableTest
    {
        [Test]
        public void PrintFirstNameTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";

            string name= driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[1]/td[2]")).Text;

            Console.WriteLine(name);
            name = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[2]/td[2]")).Text;

            Console.WriteLine(name);
        }

        [Test]
        public void PrintAllNameTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";

            int rowCount = driver.FindElements(By.XPath("//table[@id='example']/tbody/tr")).Count;
            Console.WriteLine(rowCount);
            for (int i=1;i<= rowCount; i++)
            {
                string name = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr["+i+"]/td[2]")).Text;
                string sal = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[6]")).Text;
                Console.WriteLine(name+" & "+sal);
            }
           
        }

        [Test]
        public void WorkingOnTableTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";

            int rowCount = driver.FindElements(By.XPath("//table[@id='example']/tbody/tr")).Count;

            Console.WriteLine(rowCount);
            for (int i = 1; i <= rowCount; i++)
            {
                string name = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[2]")).Text;
                
                if(name.Equals("Brenden Wagner"))
                {
                    Console.WriteLine(driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[6]")).Text);
                    driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[1]")).Click();
                    break;
                }
            }

        }
    }
}
