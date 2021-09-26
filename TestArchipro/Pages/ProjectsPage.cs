using OpenQA.Selenium;

namespace TestArchipro.Pages
{
    public class ProjectsPage : BasePage
    {
        private By listings = By.ClassName("tile-image__ImageWrapContainer");
        private By sideBarLinks = By.ClassName("collapsable-title__link");

        public By Listings { get => listings; set => listings = value; }
        public By SideBarLinks { get => sideBarLinks; set => sideBarLinks = value; }
    }
}
