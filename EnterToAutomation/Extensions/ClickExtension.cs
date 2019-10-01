using OpenQA.Selenium;

namespace EnterToTestAutomation.Extensions
{
    public static class ClickExtension
    {
        public static void ClickWithWait(this IWebDriver driver, By by)
        {
            driver.WaitForClickable(by);
            driver.FindElement(by).Click();
        }
    }
}