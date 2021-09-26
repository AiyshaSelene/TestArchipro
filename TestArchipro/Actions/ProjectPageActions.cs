using OpenQA.Selenium;
using System.Collections.Generic;
using TestArchipro.Pages;

namespace TestArchipro.Actions
{
    public class ProjectPageActions 
    {
        private ProjectsPage projectPage;
        private Find find;

        public ProjectPageActions(Find find, ProjectsPage projectPage)
        {
            this.projectPage = projectPage;
            this.find = find;
        }

        public void clickOnListingNumber(int number)
        {
            number--;
            List<IWebElement> listings = find.webElements(projectPage.Listings);
            listings[number].Click();

        }

        public void clickOnSideBarLink(int number)
        {
            List<IWebElement> sideBarLinks = find.webElements(projectPage.SideBarLinks);
            sideBarLinks[number].Click();
        }

    }
}
