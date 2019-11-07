using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace Tests
{
    public class Tests
    {
        RemoteWebDriver driver;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        public void Test1()
        {

            driver.FindElement(By.Name("q")).SendKeys("C# Automation");
            driver.FindElement(By.Name("q")).Submit();
            Assert.That(driver.Url.Contains("Automation"));
        }

        [TearDown]

        public void After()
        {
            driver.Quit();
        }
    }
}