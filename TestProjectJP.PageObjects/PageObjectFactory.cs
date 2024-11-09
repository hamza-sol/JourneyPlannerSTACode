using TestProjectJP.PageObjects.Pages;

namespace TestProjectJP.PageObjects
{
    public interface IPageObjectFactory
    {
        HomePage CreateHomePage();
    }

    public class PageObjectFactory(IWebDriverManager webDriverManager) : IPageObjectFactory
    {
        public HomePage CreateHomePage()
        {
            return new HomePage(webDriverManager);
        }
    }
}
