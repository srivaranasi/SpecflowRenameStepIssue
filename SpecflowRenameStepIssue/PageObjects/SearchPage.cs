using OpenQA.Selenium;

namespace SpecflowRenameStepIssue.PageObjects
{
    internal class SearchPage
    {
        public IWebElement searchInput => _driver.FindElement(By.Name("q"));
        public IWebElement searchButton => _driver.FindElement(By.Name("btnK"));
        public IWebElement resultStats => _driver.FindElement(By.Id("result-stats"));
        private IWebDriver _driver;

        public SearchPage(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
