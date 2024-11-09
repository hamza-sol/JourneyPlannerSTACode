using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProjectJP.PageObjects;
using TestProjectJP.PageObjects.Models;

namespace TestProjectJP.Bindings.Drivers;

public interface IJourneyPlannerWidgetDriver
{
    Task CustomerNavigatesToTflHomePage();
    void CustomerEntersFromStationNameWithAutoComplete(string stationFrom);
    void CustomerEntersToStationNameWithAutoComplete(string stationTo);
    void CustomerSelectsToPlanMyJourney();
    void VerifyInformationIsDisplayedInTheCyclingResultOfJourneyResults(Table table);
    void VerifyInformationIsDisplayedInTheWalkingResultOfJourneyResults(Table table);
    void CustomerSelectsToEditPreferenceOnJourneyResultPage();
    void CustomerSelectsRouteWithLeastWalkingOptionOnJourneyResultPreferences();
    void CustomerSelectsUpdateJourneyOnJourneyResultPreferences();
    void VerifyJourneyTimeIsDisplayedOnJourneyResultPage();
    Task CustomerIsOnJourneyResultPage(string stationFrom, string stationTo);
    Task CustomerIsOnJourneyResultPageWithLeastWalkingOption(string stationFrom, string stationTo);
    void CustomerSelectsViewDetailsOnFirstJourneyResult();
    void VerifyAccessInformationIsDisplayedForOnFirstResultOfJourneyResultPage(string stationName, Table table);
    void CustomerEntersFromStationName(string stationFrom);
    void CustomerEntersToStationName(string stationTo);
    void VerifyDisambiguationInformationPageIsDisplayedToCustomer();
    void VerifyJourneyPlannerErrorMessageIsDisplayedToCustomer();
    void CustomerClicksOnPlanMyJourney();
    void VerifyFormErrorsAreDisplayedToCustomer(Table table);
}

public class JourneyPlannerWidgetDriver(IPageContext pageContext, IPageObjectFactory pageObjectFactory) : IJourneyPlannerWidgetDriver
{
    public async Task CustomerNavigatesToTflHomePage()
    {
        pageContext.HomePage = pageObjectFactory.CreateHomePage();
        await pageContext.HomePage.GotoHomePage();
        pageContext.HomePage.AcceptCookies();
    }

    public void CustomerEntersFromStationNameWithAutoComplete(string stationFrom)
    {
        pageContext.HomePage.SelectStationFrom(stationFrom);
    }

    public void CustomerEntersToStationNameWithAutoComplete(string stationTo)
    {
        pageContext.HomePage.SelectStationTo(stationTo);
    }

    public void CustomerSelectsToPlanMyJourney()
    {
        pageContext.JourneyResultPage = pageContext.HomePage.SelectPlanMyJourney();
    }

    public void VerifyInformationIsDisplayedInTheCyclingResultOfJourneyResults(Table table)
    {
        var expectedResult = table.CreateInstance<CyclingResultInfo>();
        var actualResult = pageContext.JourneyResultPage.GetCyclingResult();
        expectedResult.Should().BeEquivalentTo(actualResult);
    }

    public void VerifyInformationIsDisplayedInTheWalkingResultOfJourneyResults(Table table)
    {
        var expectedResult = table.CreateInstance<WalkingResultInfo>();
        var actualResult = pageContext.JourneyResultPage.GetWalkingResult();
        expectedResult.Should().BeEquivalentTo(actualResult);
    }

    public void CustomerSelectsToEditPreferenceOnJourneyResultPage()
    {
        pageContext.JourneyResultPage.ClickEditPreference();
    }

    public void CustomerSelectsRouteWithLeastWalkingOptionOnJourneyResultPreferences()
    {
        pageContext.JourneyResultPage.SelectRouteWithLeastWalkingPreferenceOption();
    }

    public void CustomerSelectsUpdateJourneyOnJourneyResultPreferences()
    {
        pageContext.JourneyResultPage.ClickUpdateJourney();
    }

    public void VerifyJourneyTimeIsDisplayedOnJourneyResultPage()
    {
        pageContext.JourneyResultPage.JourneyTimeDisplayed.Should().BeTrue();
    }

    public async Task CustomerIsOnJourneyResultPage(string stationFrom, string stationTo)
    {
        await CustomerNavigatesToTflHomePage();
        CustomerEntersFromStationNameWithAutoComplete(stationFrom);
        CustomerEntersToStationNameWithAutoComplete(stationTo);
        CustomerSelectsToPlanMyJourney();
    }

    public async Task CustomerIsOnJourneyResultPageWithLeastWalkingOption(string stationFrom, string stationTo)
    {
        await CustomerIsOnJourneyResultPage(stationFrom, stationTo);
        CustomerSelectsToEditPreferenceOnJourneyResultPage();
        CustomerSelectsRouteWithLeastWalkingOptionOnJourneyResultPreferences();
        CustomerSelectsUpdateJourneyOnJourneyResultPreferences();
    }

    public void CustomerSelectsViewDetailsOnFirstJourneyResult()
    {
        pageContext.JourneyResultPage.SelectViewDetailsFirstResult();
    }

    public void VerifyAccessInformationIsDisplayedForOnFirstResultOfJourneyResultPage(string stationName, Table table)
    {
        var expectedResult = table.Rows.Select(row => row["Access Information"]).ToList();
        var actualResult = pageContext.JourneyResultPage.GetAccessInformationListForStation(stationName);
    }

    public void CustomerEntersFromStationName(string stationFrom)
    {
        pageContext.HomePage.EnterStationFrom(stationFrom);
    }

    public void CustomerEntersToStationName(string stationTo)
    {
        pageContext.HomePage.EnterStationTo(stationTo);
    }

    public void VerifyDisambiguationInformationPageIsDisplayedToCustomer()
    {
        pageContext.JourneyResultPage.DisambiguationInformationDisplayed.Should().BeTrue();
    }

    public void VerifyJourneyPlannerErrorMessageIsDisplayedToCustomer()
    {
        pageContext.JourneyResultPage.JourneyPlannerErrorMessageDisplayed.Should().BeTrue();
    }

    public void CustomerClicksOnPlanMyJourney()
    {
        pageContext.HomePage.ClicksPlanJourney();
    }

    public void VerifyFormErrorsAreDisplayedToCustomer(Table table)
    {
        var expectedMessages = table.Rows.Select(row => row["Error Message"]).ToList();
        var actualErrorMessages = pageContext.HomePage.FormErrorMessages;
        actualErrorMessages.Should().BeEquivalentTo(expectedMessages);
    }
}