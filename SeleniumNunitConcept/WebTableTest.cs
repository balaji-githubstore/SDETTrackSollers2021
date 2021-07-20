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
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";

            //string name = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[i]/td[2]")).Text;
            //Console.WriteLine(name);

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("i value = "+i+" kkkk" );

                Console.WriteLine("//table[@id='example']/tbody/tr["+i+"]/td[2]");
            }
           
        }
    }
}
