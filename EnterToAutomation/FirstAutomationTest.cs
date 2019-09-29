using System.IO;
using System.Linq;
using EnterToTestAutomation.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EnterToTestAutomation
{
    [TestFixture]
    public class FirstAutomationTest
    {
        private IWebDriver driver;
        [Test]
        public void EnterToShopPage_AddProductToCartAndClickOnTrash_CartShouldBeEmpty()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.FindElements(By.CssSelector(".menu-content a")).FirstOrDefault(x => x.Text == "DRESSES")?.Click();
            driver.WaitForClickable(By.CssSelector(".right-block h5 a"));
            driver.FindElement(By.CssSelector(".right-block h5 a")).Click();
            driver.WaitForClickable(By.CssSelector("#add_to_cart button"));
            driver.FindElement(By.CssSelector("#add_to_cart button")).Click();
            driver.WaitForClickable(By.CssSelector(".button-medium .right"));
            driver.FindElement(By.CssSelector(".button-medium .right")).Click();
            driver.WaitForClickable(By.CssSelector(".icon-trash"));
            driver.FindElement(By.CssSelector(".icon-trash")).Click();
            driver.Wait().Until(x => driver.FindElement(By.CssSelector(".alert-warning")).Text != "");
            var emptyCartText = driver.FindElement(By.CssSelector(".alert-warning")).Text;
            Assert.AreEqual(emptyCartText, "Your shopping cart is empty.");
            driver.Close();
            driver.Quit();
        }
    }
}