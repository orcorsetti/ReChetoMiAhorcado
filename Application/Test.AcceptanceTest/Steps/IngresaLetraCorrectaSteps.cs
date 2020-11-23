using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class LetraCorrectaSteps
    {
        public IWebDriver WebDriver => new ChromeDriver();

        [Given(@"the user enter the username ""(.*)"" and click login")]
        public void GivenTheUserEnterTheUsernameAndClickLogin(string p0)
        {
            WebDriver.Navigate().GoToUrl("https://localhost:44336/Inicio.aspx?testMode=true");

            IWebElement txtBoxUserName = WebDriver.FindElement(By.Id("txtBoxUserName"));
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));

            txtBoxUserName.SendKeys(p0);
            btnLogin.Click();
        }

        [Given(@"the user click to start a new game")]
        public void GivenTheUserClickToStartANewGame()
        {
            IWebElement btnStartGame = WebDriver.FindElement(By.Id("btnStartGame"));

            btnStartGame.Click();

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
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

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Then(@"the game show the letter ""(.*)"" where it belongs")]
        public void ThenTheGameShowTheLetterWhereItBelongs(string p0)
        {
            string lblLetter1 = WebDriver.FindElement(By.Id("lblLetter1")).Text;

            Assert.AreEqual(p0, lblLetter1);
        }
    }
}
