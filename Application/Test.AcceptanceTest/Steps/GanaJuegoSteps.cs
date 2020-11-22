using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class GanaJuegoSteps
    {
        public IWebDriver WebDriver => new ChromeDriver();

        [Given(@"the user enter her UserName ""(.*)"" and click the Login button")]
        public void GivenTheUserEnterHerUserNameAndClickTheLoginButton(string p0)
        {
            WebDriver.Navigate().GoToUrl("https://localhost:44336/");

            IWebElement txtBoxUserName = WebDriver.FindElement(By.Id("txtBoxUserName"));
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));

            txtBoxUserName.SendKeys(p0);
            btnLogin.Click();

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Given(@"the user starts the game")]
        public void GivenTheUserStartsTheGame()
        {
            IWebElement btnStartGame = WebDriver.FindElement(By.Id("btnStartGame"));

            btnStartGame.Click();

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Given(@"the user plays the correct letters")]
        public void GivenTheUserPlaysTheCorrectLetters(Table table)
        {
            IWebElement txtBoxLetter = WebDriver.FindElement(By.Id("txtBoxLetter"));
            IWebElement btnPlayLetter = WebDriver.FindElement(By.Id("btnPlayLetter"));

            foreach( var row in table.Rows)
            {
                txtBoxLetter.SendKeys(row[0]);
                btnPlayLetter.Click();

                WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Then(@"the user wins the game and the game congratulates her")]
        public void ThenTheUserWinsTheGameAndTheGameCongratulatesHer()
        {
            string lblGameResult = WebDriver.FindElement(By.Id("lblGameResult")).Text;

            Assert.AreEqual("Felicidades! Ganó en 6 intentos!", lblGameResult);
        }
    }
}
