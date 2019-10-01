using System.Linq;
using EnterToTestAutomation.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EnterToTestAutomation
{
    [TestFixture]
    
    public class FirstAutomationTest : BaseTest
    {
        [Test]
        public void EnterToShopPage_AddProductToCartAndClickOnTrash_CartShouldBeEmpty()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.FindElements(By.CssSelector(".menu-content a")).FirstOrDefault(x => x.Text == "DRESSES")?.Click();
            driver.ClickWithWait(By.CssSelector(".right-block h5 a"));
            driver.ClickWithWait(By.CssSelector("#add_to_cart button"));
            driver.ClickWithWait(By.CssSelector(".button-medium .right"));
            driver.ClickWithWait(By.CssSelector(".icon-trash"));
            driver.Wait().Until(x => driver.FindElement(By.CssSelector(".alert-warning")).Text != "");
            var emptyCartText = driver.FindElement(By.CssSelector(".alert-warning")).Text;
            Assert.AreEqual(emptyCartText, "Your shopping cart is empty.");
        }
    }
}