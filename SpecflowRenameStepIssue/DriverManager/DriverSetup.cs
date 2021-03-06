using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecflowRenameStepIssue.DriverManager
{
    [Binding]
    public sealed class DriverSetup
    {
            private IObjectContainer _objectContainer;
            public IWebDriver Driver;

            public DriverSetup(IObjectContainer objectContainer)
            {
                _objectContainer = objectContainer;

            }

            [BeforeScenario]
            public void BeforeScenario()
            {
                Driver = new ChromeDriver();
                _objectContainer.RegisterInstanceAs(Driver);
            }

        }
    }