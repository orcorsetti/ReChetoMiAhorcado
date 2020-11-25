using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class PierdeJuegoSteps
    {
        public IWebDriver WebDriver;

        [Given(@"the user enter her UserName ""(.*)"" and click Login")]
        public void GivenTheUserEnterHerUserNameAndClickLogin(string p0)
        {
            WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("https://ahorcadogrupo04.azurewebsites.net/Inicio.aspx?testMode=true");

            IWebElement txtBoxUserName = WebDriver.FindElement(By.Id("txtBoxUserName"));
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));

            txtBoxUserName.SendKeys(p0);
            btnLogin.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#lblUserName")));
        }
        
        [Given(@"the user start the game")]
        public void GivenTheUserStartTheGame()
        {
            IWebElement btnStarGame = WebDriver.FindElement(By.Id("btnStartGame"));
            
            btnStarGame.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#txtBoxLetter")));
        }
        
        [When(@"the user plays incorrect letters")]
        public void WhenTheUserPlaysIncorrectLetters(Table table)
        {
            IWebElement txtBoxLetter;
            IWebElement btnPlayLetter;

            foreach (var row in table.Rows)
            {
                txtBoxLetter = WebDriver.FindElement(By.CssSelector("#txtBoxLetter"));
                btnPlayLetter = WebDriver.FindElement(By.CssSelector("#btnPlayLetter"));

                txtBoxLetter.SendKeys(row[0]);
                btnPlayLetter.Click();


            }

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#lblGameResult")));
        }
        
        [Then(@"the user losses and the game confort her")]
        public void ThenTheUserLossesAndTheGameConfortHer()
        {
            string lblGameResult = WebDriver.FindElement(By.Id("lblGameResult")).Text;
            string lblWord = WebDriver.FindElement(By.Id("lblWord")).Text;

            bool testResult;
            if (lblGameResult == "Casi Casi! Perdió el Juego, intente nuevamente." && lblWord == "La palabra era salero")
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
