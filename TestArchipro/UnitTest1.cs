using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TestArchipro.Actions;
using TestArchipro.Pages;

namespace TestArchipro
{
    public class Tests
    {
        public IWebDriver driver;
        public string browserToTest = "Chrome";
        public string baseURL = "https://www.archipro.co.nz/";
        public Find find;
        public BasePage homePage = new BasePage();
        public BasePageActions homePageActions;
        public ProjectsPage projectsPage = new ProjectsPage();
        public ProjectPageActions projectPageActions;
        


        [SetUp]
        public void Setup()
        {

            if (browserToTest == "Chrome")
            {
                driver = new ChromeDriver();
            }
            else
            {
                driver = new FirefoxDriver();
            }

            find = new Find(driver);
            homePageActions = new BasePageActions(find, homePage);
            projectPageActions = new ProjectPageActions(find, projectsPage);

            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            
            homePageActions.searchFor("Bob");
            homePageActions.clickOnLink(2);
            Assert.Pass();
        }

        [Test]
        public void ProjectPageClickOnFirstListing()
        {
            homePageActions.clickOnLink(2);
            projectPageActions.clickOnListingNumber(1);
        }

        [Test]
        public void ProjectPageClickOnResidential()
        {
            homePageActions.clickOnLink(2);
            projectPageActions.clickOnSideBarLink(4);
        }
    }
}