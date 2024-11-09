using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProjectJP.PageObjects
{
    public interface IWebDriverManager
    {
        IWebDriver WebDriver { get; }
        IWait<IWebDriver> WebDriverWait { get; }
        string HomePageUrl { get; }
    }

    public class WebDriverManager(IWebDriver webDriver, IWait<IWebDriver> webDriverWait, string homePageUrl) : IWebDriverManager
    {
        public IWebDriver WebDriver { get; init; } = webDriver;
        public IWait<IWebDriver> WebDriverWait { get; init; } = webDriverWait;
        public string HomePageUrl { get; init; } = homePageUrl;
    }
}
