using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace EnterToTestAutomation.Extensions
{
    public static class WaitExtension
    {
        public static WebDriverWait Wait(this IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        public static void WaitForClickable(this IWebDriver driver ,By by)
        {
            Wait(driver).Until(ExpectedConditions.ElementToBeClickable(by));
        }
    }
}
