using AngleSharp.Dom;

using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V128.HeapProfiler;

using SeleniumExtras.WaitHelpers;

namespace TestProjectJP.PageObjects.Pages;

public class HomePage(IWebDriverManager webDriverManager) : BasePage<HomePage>(webDriverManager)
{

    public async Task<HomePage> GotoHomePage()
    {
        await WebDriver.Navigate().GoToUrlAsync(HomePageUrl);
        return WaitForPageLoad();
    }

    public void AcceptCookies()
    {
        WebDriver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll")).Click();
    }

    public void SelectStationFrom(string stationFrom)
    {
        EnterStationFrom(stationFrom);
        var suggestionMenu = FindElementAfterWait(By.Id("InputFrom-dropdown"));
        WebDriverWait.Until(_ =>
            suggestionMenu.FindElements(By.CssSelector(".tt-suggestion")).Any(element => element.Displayed));
        var suggestions = suggestionMenu.FindElements(By.CssSelector(".tt-suggestion"));
        var firstSuggestion = suggestions.First(element => element.Text.Contains(stationFrom));
        firstSuggestion.Click();
    }

    public void SelectStationTo(string stationTo)
    {
        EnterStationTo(stationTo);
        var suggestionMenu = FindElementAfterWait(By.Id("InputTo-dropdown"));
        WebDriverWait.Until(_ =>
            suggestionMenu.FindElements(By.CssSelector(".tt-suggestion")).Any(element => element.Displayed));
        var firstSuggestion = FindElementAfterWait(By.Id("InputTo-dropdown")).FindElements(By.CssSelector(".tt-suggestion"))
            .First(element => element.Text.Contains(stationTo));
        firstSuggestion.Click();
    }

    public JourneyResultPage SelectPlanMyJourney()
    {
        ClicksPlanJourney();
        return new JourneyResultPage(webDriverManager).WaitForPageLoad();
    }

    public override HomePage WaitForPageLoad()
    {
        WebDriverWait.Until(ExpectedConditions.TitleIs("Keeping London moving - Transport for London"));
        return this;
    }

    public void EnterStationFrom(string stationFrom)
    {
        WebDriver.FindElement(By.Id("InputFrom")).SendKeys(stationFrom);
    }

    public void EnterStationTo(string stationTo)
    {
        WebDriver.FindElement(By.Id("InputTo")).SendKeys(stationTo);
    }

    public void ClicksPlanJourney()
    {
        FindElementAfterWait(By.Id("plan-journey-button")).Click();
    }

    public IList<string> FormErrorMessages => WebDriver.FindElements(By.CssSelector(".field-validation-error"))
        .Where(element => element.Displayed).Select(element => element.Text).ToList();
}