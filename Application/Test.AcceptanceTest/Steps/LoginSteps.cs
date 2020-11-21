using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class LoginSteps
    {
        public IWebDriver webDriver => new ChromeDriver();

        //Steps Definitions

        [Given(@"the user enter the application")]
        public void GivenTheUserEnterTheApplication()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44336/");
        }

        [Given(@"he enter her username ""(.*)""")]
        public void GivenHeEnterHerUsername(string p0)
        {
            IWebElement txtBoxUserName = webDriver.FindElement(By.Id("txtBoxUserName"));
            txtBoxUserName.SendKeys(p0);
        }



        [When(@"he clicked the login button")]
        public void WhenHeClickedTheLoginButton()
        {
            IWebElement btnLogin = webDriver.FindElement(By.Id("btnLogin"));
            btnLogin.Click();
        }

        [Then(@"the main menu of the app is loaded with the username ""(.*)""")]
        public void ThenTheMainMenuOfTheAppIsLoadedWithTheUsername(string p0)
        {

            string userNameDisplayed = webDriver.FindElement(By.Id("lblUserName")).Text;

            bool testResult;
            if (userNameDisplayed == p0)
            {
               testResult = true;
            }
            else
            {
               testResult =  false;
            }

            Assert.IsTrue(testResult);

        }

    }
}
