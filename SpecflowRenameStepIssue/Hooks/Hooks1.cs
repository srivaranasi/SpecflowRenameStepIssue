using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecflowRenameStepIssue.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        public IWebDriver Driver;
        public Hooks1(IWebDriver driver)
        {
            Driver = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}