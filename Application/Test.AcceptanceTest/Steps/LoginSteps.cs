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
        public IWebDriver WebDriver => new ChromeDriver();

        //Steps Definitions

        [Given(@"the user enter the application")]
        public void GivenTheUserEnterTheApplication()
        {
            WebDriver.Navigate().GoToUrl("https://localhost:44336/Inicio.aspx");
        }

        [Given(@"he enter her username ""(.*)""")]
        public void GivenHeEnterHerUsername(string p0)
        {
            IWebElement txtBoxUserName = WebDriver.FindElement(By.Id("txtBoxUserName"));
            txtBoxUserName.SendKeys(p0);
        }



        [When(@"he clicked the login button")]
        public void WhenHeClickedTheLoginButton()
        {
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));
            btnLogin.Click();

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Then(@"the main menu of the app is loaded with the username ""(.*)""")]
        public void ThenTheMainMenuOfTheAppIsLoadedWithTheUsername(string p0)
        {

            string userNameDisplayed = WebDriver.FindElement(By.Id("lblUserName")).Text;

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
