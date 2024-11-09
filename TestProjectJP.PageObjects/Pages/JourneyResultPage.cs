using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Input;

using SeleniumExtras.WaitHelpers;

using TestProjectJP.PageObjects.Models;

namespace TestProjectJP.PageObjects.Pages;

public class JourneyResultPage(IWebDriverManager webDriverManager) : BasePage<JourneyResultPage>(webDriverManager)
{
    public CyclingResultInfo GetCyclingResult()
    {
        var cyclingResultContainer = FindElementAfterWait(By.CssSelector("[data-tracking-value='JP: Cycling']"));
        return new CyclingResultInfo()
        {
            Route = cyclingResultContainer.FindElement(By.CssSelector(".route-data  p:first-of-type strong")).Text,
            Distance = cyclingResultContainer.FindElement(By.CssSelector(".route-data  p:last-of-type strong")).Text,
            Duration = cyclingResultContainer.FindElement(By.CssSelector(".journey-info")).Text
        };
    }
    public WalkingResultInfo GetWalkingResult()
    {
        var walkingResultContainer = FindElementAfterWait(By.CssSelector("[data-tracking-value='JP: WalkingOnly']"));
        return new WalkingResultInfo()
        {
            WalkingSpeed = walkingResultContainer.FindElement(By.CssSelector(".route-data  p:first-of-type strong")).Text,
            Distance = walkingResultContainer.FindElement(By.CssSelector(".route-data  p:last-of-type strong")).Text,
            Duration = walkingResultContainer.FindElement(By.CssSelector(".journey-info")).Text
        };
    }

    public override JourneyResultPage WaitForPageLoad()
    {
        WebDriverWait.Until(ExpectedConditions.TextToBePresentInElement(WebDriver.FindElement(By.TagName("h1")), "Journey results"));
        return this;
    }


    public void ClickEditPreference()
    {
        FindElementAfterWait(By.CssSelector("[aria-controls='more-journey-options']")).Click(); ;
    }

    public void SelectRouteWithLeastWalkingPreferenceOption()
    {
        FindElementAfterWait(By.CssSelector("[for='JourneyPreference_2']")).Click();
    }

    public void ClickUpdateJourney()
    {
        WebDriver.FindElement(By.Id("jp-search-form")).Submit();
    }

    public bool JourneyTimeDisplayed
    {
        get
        {
            try
            {
                WebDriverWait.Until(_ =>
                    WebDriver.FindElements(By.CssSelector(".journey-time")).Any(element => element.Displayed));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public bool DisambiguationInformationDisplayed
    {
        get
        {
            try
            {
                WebDriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".disambiguation-form")));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public bool JourneyPlannerErrorMessageDisplayed
    {
        get
        {
            try
            {
                WebDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector(".field-validation-error")));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public void SelectViewDetailsFirstResult()
    {
        WebDriverWait.Until(_ =>
            WebDriver.FindElements(By.CssSelector(".show-detailed-results")).Any(element => element.Displayed));
        WebDriver.FindElements(By.CssSelector(".show-detailed-results")).First(element => element.Displayed).Click();
    }

    public IList<string> GetAccessInformationListForStation(string stationName)
    {
        //By.XPath(
        //    $"//div[contains(@class, 'step-heading') and .//span[contains(text(), '{stationName}')]]/following-sibling::div//a[contains(@class, 'tooltip-container')");
        //var container = FindElementAfterWait(By.CssSelector(".access-information"));
        //var anchors = container.FindElements(By.CssSelector("a.tooltip-container"));
        //var anchor1s = WebDriver.FindElements(By.XPath(
        //    $"//div[contains(@class, 'step-heading') and .//span[contains(text(), '{stationName}')]]/following-sibling::div//a[contains(@class, 'tooltip-container')"));
        var anchorContainer = WebDriver.FindElement(By.XPath(
            $"//div[contains(@class, 'step-heading') and .//span[contains(text(), '{stationName}')]]"));
        return anchorContainer.FindElements(By.CssSelector("a.tooltip-container")).Select(element => element.GetAttribute("aria-label")).ToList();
    }
}