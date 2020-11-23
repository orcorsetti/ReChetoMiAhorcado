using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class PierdeJuegoSteps
    {
        public IWebDriver WebDriver => new ChromeDriver();

        [Given(@"the user enter her UserName ""(.*)"" and click Login")]
        public void GivenTheUserEnterHerUserNameAndClickLogin(string p0)
        {
            WebDriver.Navigate().GoToUrl("https://localhost:44336/Inicio.aspx?testMode=true");

            IWebElement txtBoxUserName = WebDriver.FindElement(By.Id("txtBoxUserName"));
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));

            txtBoxUserName.SendKeys(p0);
            btnLogin.Click();

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Given(@"the user start the game")]
        public void GivenTheUserStartTheGame()
        {
            IWebElement btnStarGame = WebDriver.FindElement(By.Id("btnStartGame"));
            
            btnStarGame.Click();
        }
        
        [When(@"the user plays incorrect letters")]
        public void WhenTheUserPlaysIncorrectLetters(Table table)
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
        
        [Then(@"the user losses and the game confort her")]
        public void ThenTheUserLossesAndTheGameConfortHer()
        {
            string lblGameResult = WebDriver.FindElement(By.Id("lblGameResult")).Text;

            Assert.AreEqual("Casi Casi! Perdió el Juego, intente nuevamente.", lblGameResult);
        }
    }
}
