using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class IngresaLetraIncorrectaSteps
    {
        public IWebDriver WebDriver;

        [Given(@"the use enter the username ""(.*)"" and click login")]
        public void GivenTheUseEnterTheUsernameAndClickLogin(string p0)
        {
            WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("https://ahorcadogrupo04.azurewebsites.net/Inicio.aspx?testMode=true");

            IWebElement txtBoxUserName = WebDriver.FindElement(By.Id("txtBoxUserName"));
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));

            txtBoxUserName.SendKeys(p0);
            btnLogin.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#lblUserName")));
        }
        
        [Given(@"the user click star a new game")]
        public void GivenTheUserClickStarANewGame()
        {
            IWebElement btnStartGame = WebDriver.FindElement(By.Id("btnStartGame"));

            btnStartGame.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#txtBoxLetter")));
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

            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#lblLetter0")));
        }
        
        [Then(@"the game shows the letter ""(.*)"" as incorrect and the remaining attemps are ""(.*)""")]
        public void ThenTheGameShowsTheLetterAsIncorrectAndTheRemainingAttempsAre(string p0, int p1)
        {
            string lblIncorrectLetter = WebDriver.FindElement(By.CssSelector("#lblIncorrectLetter")).Text;
            string lblRemainingAttemps = WebDriver.FindElement(By.CssSelector("#lblRemainingAttempts")).Text;

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
