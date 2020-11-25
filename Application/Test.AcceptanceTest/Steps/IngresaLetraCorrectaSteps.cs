using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class LetraCorrectaSteps
    {
        public IWebDriver WebDriver;

        [Given(@"the user enter the username ""(.*)"" and click login")]
        public void GivenTheUserEnterTheUsernameAndClickLogin(string p0)
        {
            WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("https://ahorcadogrupo04.azurewebsites.net/Inicio.aspx?testMode=true");


            IWebElement txtBoxUserName = WebDriver.FindElement(By.Id("txtBoxUserName"));
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));

            txtBoxUserName.SendKeys(p0);
            btnLogin.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#lblUserName")));
        }

        [Given(@"the user click to start a new game")]
        public void GivenTheUserClickToStartANewGame()
        {
            IWebElement btnStartGame = WebDriver.FindElement(By.Id("btnStartGame"));

            btnStartGame.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#txtBoxLetter")));
        }

        [Given(@"the user enter a correct letter ""(.*)""")]
        public void GivenTheUserEnterACorrectLetter(string p0)
        {
            IWebElement txtBoxLetter = WebDriver.FindElement(By.Id("txtBoxLetter"));
            txtBoxLetter.SendKeys(p0);
        }

        [When(@"the user clicked the play button")]
        public void WhenTheUserClickedThePlayButton()
        {
            IWebElement btnPlayLetter = WebDriver.FindElement(By.Id("btnPlayLetter"));
            btnPlayLetter.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#lblLetter0")));
        }

        [Then(@"the game show the letter ""(.*)"" where it belongs")]
        public void ThenTheGameShowTheLetterWhereItBelongs(string p0)
        {
            string lblLetter1 = WebDriver.FindElement(By.CssSelector("#lblLetter0")).Text;

            Assert.AreEqual(p0, lblLetter1);
        }
    }
}
