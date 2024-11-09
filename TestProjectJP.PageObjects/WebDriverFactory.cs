using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectJP.PageObjects
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(string? browser)
        {
            if (string.IsNullOrEmpty(browser)) throw new Exception("please provide Browser value");
            switch (browser.ToLower())
            {
                case "edge":
                    new DriverManager().SetUpDriver(new EdgeConfig(), "MatchingBrowser");
                    return new EdgeDriver();
                default:
                    throw new Exception("unsupported browser");
            }
        }
    }
}
