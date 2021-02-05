﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SeleniumTests
{
    class SeleniumFirst
    {
        public static async Task Main(string[] args) { Console.ReadKey(); }
        private IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Quit();
        }

        [Test]
        public void FirstTest()
        {
            //Given
            string email = "den25051999@gmail.com";
            string password = "admin1234";
            string webSite = "https://vseosvita.ua/";
            string personalOffice = "https://vseosvita.ua/user/id1277827";
            string buttonText = "+ Додати матеріал";

            //When
            Console.WriteLine("FirstTest1() ThreadID= " + Thread.CurrentThread.ManagedThreadId);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Launching test page
            driver.Navigate().GoToUrl(webSite);
            //Click on drop-down menu
            driver.FindElement(By.XPath("/html/body/header/div/div/div[1]/a[2]")).Click();
            //go to login page
            driver.FindElement(By.CssSelector("body > header > div > div > div.v-hide-on-mobile.vr-hide-on-mobile-new > div > div.n-row-menu.n-row-top-menu > div.n-menu-col.n-menu-col-kabinet > div.a-registration > a:nth-child(2)")).Click();
            //e-mail
            driver.FindElement(By.Id("login-email")).SendKeys(email);
            //password
            driver.FindElement(By.Id("login-password")).SendKeys(password + Keys.Enter);
            Thread.Sleep(2000);
            //Checking for new(after login) functions
            driver.Navigate().GoToUrl(personalOffice);
            Thread.Sleep(2000);
            IWebElement actual = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/center/div/a"));

            //Then
            Assert.AreEqual(actual.Text, buttonText);
        }
    }
}