using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class IngresaLetraIncorrectaSteps
    {
        public IWebDriver WebDriver => new ChromeDriver();

        [Given(@"the use enter the username ""(.*)"" and click login")]
        public void GivenTheUseEnterTheUsernameAndClickLogin(string p0)
        {
            WebDriver.Navigate().GoToUrl("https://localhost:44336/");

            IWebElement txtBoxUserName = WebDriver.FindElement(By.Id("txtBoxUserName"));
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));

            txtBoxUserName.SendKeys(p0);
            btnLogin.Click();

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Given(@"the user click star a new game")]
        public void GivenTheUserClickStarANewGame()
        {
            IWebElement btnStartGame = WebDriver.FindElement(By.Id("btnStartGame"));

            btnStartGame.Click();

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Given(@"the user enter an incorrect letter ""(.*)""")]
        public void GivenTheUserEnterAnIncorrectLetter(string p0)
        {
            IWebElement txtBoxLetter = WebDriver.FindElement(By.Id("txtBoxLetter"));

            txtBoxLetter.SendKeys(p0);
        }
        
        [When(@"the user click the play button")]
        public void WhenTheUserClickThePlayButton()
        {
            IWebElement btnPlayLetter = WebDriver.FindElement(By.Id("btnPlayLetter"));

            btnPlayLetter.Click();

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Then(@"the game shows the letter ""(.*)"" as incorrect and the remaining attemps are ""(.*)""")]
        public void ThenTheGameShowsTheLetterAsIncorrectAndTheRemainingAttempsAre(string p0, int p1)
        {
            string lblIncorrectLetter = WebDriver.FindElement(By.Id("lblIncorrectLetter")).Text;
            string lblRemainingAttemps = WebDriver.FindElement(By.Id("lblRemainingAttemps")).Text;

            bool testResult;

            if (lblIncorrectLetter.Contains(p0) && lblRemainingAttemps == p1.ToString())
            {
                testResult = true;    
            }
            else
            {
                testResult = false;
            }

            Assert.IsTrue(testResult);
        }
    }
}
