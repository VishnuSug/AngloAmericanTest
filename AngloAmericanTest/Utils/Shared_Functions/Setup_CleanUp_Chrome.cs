using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AngloAmericanTest.Utils.Shared_Functions
{
    [TestClass]
    public abstract class TestSetUp_Chrome
    {
        public static IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
