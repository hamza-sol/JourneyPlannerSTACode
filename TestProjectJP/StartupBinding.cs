using BoDi;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using TechTalk.SpecFlow;
using TestProjectJP.Bindings;
using TestProjectJP.Bindings.Drivers;
using TestProjectJP.PageObjects;

namespace TestProjectJP.Tests;

[Binding]
public class StartupBinding
{
    [BeforeScenario]
    public static void BeforeFeature(IObjectContainer objectContainer)
    {
        objectContainer.RegisterTypeAs<PageContext, IPageContext>();
        objectContainer.RegisterFactoryAs(_ => WebDriverFactory.CreateWebDriver(TestContext.Parameters["Browser"]));
        objectContainer.RegisterInstanceAs(new WebDriverWait(objectContainer.Resolve<IWebDriver>(),
            TimeSpan.FromSeconds(int.Parse(TestContext.Parameters["TimeOutInSeconds"] ??
                                           throw new Exception("TimeOutInSeconds cannot be null")))));
        objectContainer.RegisterFactoryAs(container =>
            (IWebDriverManager)new PageObjects.WebDriverManager(container.Resolve<IWebDriver>(),
                container.Resolve<WebDriverWait>(),
                TestContext.Parameters["HomePageUrl"] ?? throw new Exception("HomePageUrl cannot be null")));
        objectContainer.RegisterTypeAs<PageObjectFactory, IPageObjectFactory>();
        objectContainer.RegisterTypeAs<JourneyPlannerWidgetDriver, IJourneyPlannerWidgetDriver>();
    }

    [AfterScenario]
    public static void AfterScenario(IObjectContainer objectContainer)
    {
        var webDriverManager = objectContainer.Resolve<IWebDriverManager>();
        webDriverManager?.WebDriver.Dispose();
    }
}