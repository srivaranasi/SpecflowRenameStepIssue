using FluentAssertions;
using OpenQA.Selenium;
using SpecflowRenameStepIssue.PageObjects;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowRenameStepIssue.Steps
{
    [Binding]
    public sealed class StepDefinitions
    {
        private SearchPage searchPage => new SearchPage(_driver);
        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;
        public StepDefinitions(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am on google home page")]
        public void GivenIAmOnGoogleHomePage()
        {
            _driver.Navigate().GoToUrl("http://google.com");
        }

        [When(@"I enter text ""([^""]*)""")]
        public void WhenIEnterText(string searchTerm)
        {
            searchPage.searchInput.SendKeys(searchTerm);
        }

        [When(@"I select search button")]
        public void WhenISelectSearchButton()
        {
            searchPage.searchInput.SendKeys(Keys.Escape);
            Thread.Sleep(3000);      
            searchPage.searchButton.Click();
        }

        [Then(@"I should see resluts pages")]
        public void ThenIShouldSeeReslutsPages()
        {
            searchPage.resultStats.Text.Should().Contain("About");
        }
    }
}