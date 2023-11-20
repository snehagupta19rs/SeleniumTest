using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;

namespace POCTestProject.Tests.Hooks
{
    [Binding]
    public class MyHooks
    {
        public IWebDriver driver;
        [BeforeScenario]
        public void SetDesiredCapabilities()
        {
            
            DriverOptions capability = new ChromeOptions();

            capability.BrowserVersion = "latest";

            capability.AddAdditionalOption("bstack:options", capability);
            driver = new RemoteWebDriver(
              new Uri("http://localhost:4444/wd/hub/"),
              capability);



        }

        [AfterScenario]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
