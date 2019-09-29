using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EnterToTestAutomation
{
    public class BaseTest
    {
        protected IWebDriver driver;
        
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Manage().Window.Maximize();
        }
        
        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}