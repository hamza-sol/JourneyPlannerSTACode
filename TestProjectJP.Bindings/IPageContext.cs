using TestProjectJP.PageObjects.Pages;

namespace TestProjectJP.Bindings;

public interface IPageContext
{
    HomePage HomePage { get; set; }
    JourneyResultPage JourneyResultPage { get; set; }
}