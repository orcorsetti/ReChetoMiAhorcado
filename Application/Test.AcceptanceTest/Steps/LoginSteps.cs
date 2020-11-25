using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class LoginSteps
    {
        public IWebDriver WebDriver;

        //Steps Definitions

        [Given(@"the user enter the application")]
        public void GivenTheUserEnterTheApplication()
        {
            WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("https://ahorcadogrupo04.azurewebsites.net/Inicio.aspx");
            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#txtBoxUserName")));
        }

        [Given(@"he enter her username ""(.*)""")]
        public void GivenHeEnterHerUsername(string p0)
        {
            IWebElement txtBoxUserName = WebDriver.FindElement(By.CssSelector("#txtBoxUserName"));
            txtBoxUserName.SendKeys(p0);
        }



        [When(@"he clicked the login button")]
        public void WhenHeClickedTheLoginButton()
        {
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));
            btnLogin.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#lblUserName")));
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
