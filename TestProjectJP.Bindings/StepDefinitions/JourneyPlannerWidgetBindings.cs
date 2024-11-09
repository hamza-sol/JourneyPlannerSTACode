using TechTalk.SpecFlow;

using TestProjectJP.Bindings.Drivers;

namespace TestProjectJP.Bindings.StepDefinitions;

[Binding]
public class JourneyPlannerWidgetBindings(IJourneyPlannerWidgetDriver journeyPlannerWidgetDriver)
{
    [Given("customer is on tfl home page")]
    public async Task GivenCustomerIsOnTflHomePage()
    {
        await journeyPlannerWidgetDriver.CustomerNavigatesToTflHomePage();
    }

    [When("customer enters '(.*)' in from field and selects to autocomplete the station name")]
    public void WhenCustomerEntersInFromFieldAndSelectsToAutocompleteTheStationName(string stationFrom)
    {
        journeyPlannerWidgetDriver.CustomerEntersFromStationNameWithAutoComplete(stationFrom);
    }

    [When("customer enters '(.*)' in from field")]
    public void WhenCustomerEntersInFromField(string stationFrom)
    {
        journeyPlannerWidgetDriver.CustomerEntersFromStationName(stationFrom);
    }
    
    [When("customer enters '(.*)' in to field")]
    public void WhenCustomerEntersInToField(string stationTo)
    {
        journeyPlannerWidgetDriver.CustomerEntersToStationName(stationTo);
    }


    [When("customer enters '(.*)' in to field and selects to autocomplete the station name")]
    public void WhenCustomerEntersInToFieldAndSelectsToAutocompleteTheStationName(string stationTo)
    {
        journeyPlannerWidgetDriver.CustomerEntersToStationNameWithAutoComplete(stationTo);
    }

    [When("customer selects to plan my journey")]
    public void WhenCustomerSelectsToPlanMyJourney()
    {
        journeyPlannerWidgetDriver.CustomerSelectsToPlanMyJourney();
    }

    [When("customer clicks on plan my journey")]
    public void WhenCustomerClicksOnPlanMyJourney()
    {
        journeyPlannerWidgetDriver.CustomerClicksOnPlanMyJourney();
    }


    [Then("following information is displayed in the cycling result of journey results:")]
    public void ThenFollowingInformationIsDisplayedInTheCyclingResultOfJourneyResults(Table table)
    {
        journeyPlannerWidgetDriver.VerifyInformationIsDisplayedInTheCyclingResultOfJourneyResults(table);
    }

    [Then("following information is displayed in the walking result of journey results:")]
    public void ThenFollowingInformationIsDisplayedInTheWalkingResultOfJourneyResults(Table table)
    {
        journeyPlannerWidgetDriver.VerifyInformationIsDisplayedInTheWalkingResultOfJourneyResults(table);
    }

    [Given("customer is on journey result page for journey from '(.*)' to '(.*)'")]
    public async Task GivenCustomerIsOnJourneyResultPageForJourneyFromTo(string stationFrom, string stationTo)
    {
        await journeyPlannerWidgetDriver.CustomerIsOnJourneyResultPage(stationFrom, stationTo);
    }

    [When("customer selects to edit preference on journey result page")]
    public void WhenCustomerSelectsToEditPreferenceOnJourneyResultPage()
    {
        journeyPlannerWidgetDriver.CustomerSelectsToEditPreferenceOnJourneyResultPage();
    }

    [When("customer selects route with least walking option on journey result preferences")]
    public void WhenCustomerSelectsRouteWithLeastWalkingOptionOnJourneyResultPreferences()
    {
        journeyPlannerWidgetDriver.CustomerSelectsRouteWithLeastWalkingOptionOnJourneyResultPreferences();
    }

    [When("customer selects update journey on journey result preferences")]
    public void WhenCustomerSelectsUpdateJourneyOnJourneyResultPreferences()
    {
        journeyPlannerWidgetDriver.CustomerSelectsUpdateJourneyOnJourneyResultPreferences();
    }

    [Then("journey time is displayed on journey result page")]
    public void ThenJourneyTimeIsDisplayedOnJourneyResultPage()
    {
        journeyPlannerWidgetDriver.VerifyJourneyTimeIsDisplayedOnJourneyResultPage();
    }

    [Given("customer is on journey result page for journey with least walking option from '(.*)' to '(.*)'")]
    public async Task GivenCustomerIsOnJourneyResultPageForJourneyWithLeastWalkingOptionFromTo(string stationFrom, string stationTo)
    {
        await journeyPlannerWidgetDriver.CustomerIsOnJourneyResultPageWithLeastWalkingOption(stationFrom, stationTo);
    }

    [When("customer selects view details on first journey result")]
    public void WhenCustomerSelectsViewDetailsOnFirstJourneyResult()
    {
        journeyPlannerWidgetDriver.CustomerSelectsViewDetailsOnFirstJourneyResult();
    }

    [Then("following access information is displayed for '(.*)' on first result of journey result page:")]
    public void ThenFollowingAccessInformationIsDisplayedForOnFirstResultOfJourneyResultPage(string stationName, Table table)
    {
        journeyPlannerWidgetDriver.VerifyAccessInformationIsDisplayedForOnFirstResultOfJourneyResultPage(stationName, table);
    }

    [Then("disambiguation information page is displayed to customer")]
    public void ThenDisambiguationInformationPageIsDisplayedToCustomer()
    {
        journeyPlannerWidgetDriver.VerifyDisambiguationInformationPageIsDisplayedToCustomer();
    }

    [Then("journey planner error message is displayed to customer")]
    public void ThenJourneyPlannerErrorMessageIsDisplayedToCustomer()
    {
        journeyPlannerWidgetDriver.VerifyJourneyPlannerErrorMessageIsDisplayedToCustomer();
    }

    [Then("following form errors are displayed to customer:")]
    public void ThenFollowingFormErrorsAreDisplayedToCustomer(Table table)
    {
        journeyPlannerWidgetDriver.VerifyFormErrorsAreDisplayedToCustomer(table);
    }
}