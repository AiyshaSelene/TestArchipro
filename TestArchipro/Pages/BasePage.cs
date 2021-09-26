using OpenQA.Selenium;

namespace TestArchipro.Pages
{
    public class BasePage
    {
        private By productLink = By.Id("link0");
        private By projectLink = By.Id("link1");
        private By professionalLink = By.Id("link2");
        private By searchBar = By.XPath("//input[@type='search']");
        private By searchButton = By.XPath("//div[@data-testid='variable-provider']//button//*[name()='svg']");

        public By ProductLink { get => productLink; set => productLink = value; }
        public By ProjectLink { get => projectLink; set => projectLink = value; }
        public By ProfessionalLink { get => professionalLink; set => professionalLink = value; }
        public By SearchBar { get => searchBar; set => searchBar = value; }
        public By SearchButton { get => searchButton; set => searchButton = value; }
    }
}
