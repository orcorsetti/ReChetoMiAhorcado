using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Test.AcceptanceTest.Pages;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class LoginSteps
    {
        //Anti-
        LoginPage loginPage = null;

        //Steps Definitions

        [Given(@"the user enter the application")]
        public void GivenTheUserEnterTheApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://localhost:44336/");
            loginPage = new LoginPage(webDriver);
        }

        [Given(@"he enter her username ""(.*)""")]
        public void GivenHeEnterHerUsername(string p0)
        {
            loginPage.Login(p0);
        }



        [When(@"he clicked the login button")]
        public void WhenHeClickedTheLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then(@"the main menu of the app is loaded with the username ""(.*)""")]
        public void ThenTheMainMenuOfTheAppIsLoadedWithTheUsername(string p0)
        {
            bool testResult = loginPage.IsLoginCorrect(p0);

            Assert.IsTrue(testResult);

        }

    }
}
