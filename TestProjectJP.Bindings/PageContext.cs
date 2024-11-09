using TestProjectJP.PageObjects.Pages;

namespace TestProjectJP.Bindings;

public class PageContext : IPageContext
{
    public HomePage HomePage { get; set; }
    public JourneyResultPage JourneyResultPage { get; set; }
}