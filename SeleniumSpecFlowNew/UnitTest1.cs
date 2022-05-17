using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace SeleniumSpecFlowNew
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            Console.WriteLine("hhh");
            driver = new ChromeDriver(path + @"\drivers\");
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("toms");
            Console.WriteLine("hhh");
            Assert.Pass();
        }
    }
}
