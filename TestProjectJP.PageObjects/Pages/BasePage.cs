using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProjectJP.PageObjects.Pages;

public abstract class BasePage<T>(IWebDriverManager webDriverManager) where T : BasePage<T>
{
    protected IWebDriver WebDriver => webDriverManager.WebDriver;
    protected string HomePageUrl => webDriverManager.HomePageUrl;
    protected IWait<IWebDriver> WebDriverWait => webDriverManager.WebDriverWait;

    protected IWebElement FindElementAfterWait(By selector)
    {
        WebDriverWait.Until(_ => WebDriver.FindElements(selector).Any(element => element.Displayed));
        return WebDriver.FindElement(selector);
    }

    public abstract T WaitForPageLoad();
}