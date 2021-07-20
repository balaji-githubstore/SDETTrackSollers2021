﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumNunitConcept.OpenEmr
{
    class OpenEMRTest
    {
        [Test]
        public void AddPatientTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";

            driver.FindElement(By.CssSelector("#authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement select = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            select.SelectByText("English (Indian)");
            //click login

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            
            driver.FindElement(By.XPath("//div[text()='Patient/Client']")).Click();
            driver.FindElement(By.XPath("//div[text()='Patients']")).Click();

            driver.SwitchTo().Frame("fin");
            driver.FindElement(By.Id("create_patient_btn1")).Click();
            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame("pat");

            driver.FindElement(By.Id("form_fname")).SendKeys("bala");
            driver.FindElement(By.Id("form_lname")).SendKeys("dina");
            driver.FindElement(By.Id("form_DOB")).SendKeys("2021-07-19");
            SelectElement selectGender = new SelectElement(driver.FindElement(By.Id("form_sex")));
            selectGender.SelectByText("Female");  
            driver.FindElement(By.Id("create")).Click();

            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame("modalframe");       
            //driver.FindElement(By.XPath("//input[@value='Confirm Create New Patient']")).Click();
            driver.SwitchTo().DefaultContent();

            //explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50)); //ignores all the exception
            wait.Until(x => x.SwitchTo().Alert()); 

            //string actualValueFromAlert = wait.Until(x => x.SwitchTo().Alert()).Text;
            //Console.WriteLine(actualValueFromAlert);

            //wait.Until(x => x.SwitchTo().Alert()).Accept();

            string actualValueFromAlert = driver.SwitchTo().Alert().Text;
            Console.WriteLine(actualValueFromAlert);

            driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void AddPatient1Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";

            driver.FindElement(By.CssSelector("#authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement select = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            select.SelectByText("English (Indian)");
            //click login

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            
            driver.FindElement(By.XPath("//div[text()='Patient/Client']")).Click();
            driver.FindElement(By.XPath("//div[text()='Patients']")).Click();

            driver.SwitchTo().Frame("fin");
            driver.FindElement(By.Id("create_patient_btn1")).Click();
            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame("pat");

            driver.FindElement(By.Id("form_fname")).SendKeys("bala");
            driver.FindElement(By.Id("form_lname")).SendKeys("dina");
            driver.FindElement(By.Id("form_DOB")).SendKeys("2021-07-19");
            SelectElement selectGender = new SelectElement(driver.FindElement(By.Id("form_sex")));
            selectGender.SelectByText("Female");  
            driver.FindElement(By.Id("create")).Click();

            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame("modalframe");       
            driver.FindElement(By.XPath("//input[@value='Confirm Create New Patient']")).Click();
            driver.SwitchTo().DefaultContent();

            //fluent wait
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.PollingInterval = TimeSpan.FromSeconds(5);
            wait.IgnoreExceptionTypes(typeof(NoAlertPresentException));//ignore no alert exception
            //wait.IgnoreExceptionTypes(typeof(NoAlertPresentException),typeof(ElementNotInteractableException));
            wait.IgnoreExceptionTypes(typeof(Exception)); //ignore all the exceptions
            string actualValueFromAlert = wait.Until(x => x.SwitchTo().Alert()).Text;
            Console.WriteLine(actualValueFromAlert);

            wait.Until(x => x.SwitchTo().Alert()).Accept();


        }
        [Test]
        public void AddPatient2Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";

            driver.FindElement(By.CssSelector("#authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement select = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            select.SelectByText("English (Indian)");
            //click login

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            driver.FindElement(By.XPath("//div[text()='Patient/Client']")).Click();
            driver.FindElement(By.XPath("//div[text()='Patients']")).Click();

            driver.SwitchTo().Frame("fin");
            driver.FindElement(By.Id("create_patient_btn1")).Click();
            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame("pat");

            driver.FindElement(By.Id("form_fname")).SendKeys("bala");
            driver.FindElement(By.Id("form_lname")).SendKeys("dina");
            driver.FindElement(By.Id("form_DOB")).SendKeys("2021-07-19");
            SelectElement selectGender = new SelectElement(driver.FindElement(By.Id("form_sex")));
            selectGender.SelectByText("Female");
            driver.FindElement(By.Id("create")).Click();

            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame("modalframe");
            driver.FindElement(By.XPath("//input[@value='Confirm Create New Patient']")).Click();
            driver.SwitchTo().DefaultContent();

            //fluent wait
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.PollingInterval = TimeSpan.FromSeconds(5);
            wait.IgnoreExceptionTypes(typeof(NoAlertPresentException));//ignore no alert exception

            string actualValueOfAlert = wait.Until(x => x.SwitchTo().Alert()).Text;
            Console.WriteLine(actualValueOfAlert);

            wait.Until(x => x.SwitchTo().Alert()).Accept();

            if(driver.FindElements(By.XPath("//div[@class='closeDlgIframe']")).Count>0) // check element present or not
            {
                driver.FindElement(By.XPath("//div[@class='closeDlgIframe']")).Click();
            }
            //driver.SwitchTo().Frame("Pat");
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[contains(@src,'new.php')]")));

           String actualValueOfAddedPatient= driver.FindElement(By.XPath("//h2[contains(text(),'Medical')]")).Text;


            Assert.IsTrue(actualValueOfAlert.Contains("Assessment: Tobacco"));//given condition must be true otherwise method is failure

            Assert.AreEqual("Medical Record Dashboard - Bala Dina", actualValueOfAddedPatient);

        }


        //if(driver.FindElement(By.XPath("//div[@class='closeDlgIframe']")).Displayed)
        //{
        //    //
        //}


        //public bool IsElementPresent()
        //{
        //    try
        //    {
        //        driver.FindElement(By.XPath("//div[@class='closeDlgIframe']"));
        //        return true;
        //    }
        //    catch
        //    {
        //        return false
        //    }
        //}
    }
}
