using OpenQA.Selenium;
using TestArchipro.Pages;

namespace TestArchipro.Actions
{
    public class BasePageActions
    {
        private Find find;
        private BasePage homePage;

        public BasePageActions(Find find, BasePage basePage)
        {
            this.find = find;
            this.homePage = basePage;
        }

        public void searchFor(string search)
        {
            IWebElement el = find.webElement(homePage.SearchBar);
            el.Click();
            el.SendKeys(search);
        }

        public void clickOnLink(int linkNumber)
        {
            if (linkNumber == 1)
            {
                IWebElement productLink = find.webElement(homePage.ProductLink);
                productLink.Click();
            }
            else if (linkNumber == 2)
            {
                IWebElement projectLink = find.webElement(homePage.ProjectLink);
                projectLink.Click();
            }
            else if(linkNumber == 3)
            {
                IWebElement professionalLink = find.webElement(homePage.ProfessionalLink);
                professionalLink.Click();
            }
        }
    }
}
