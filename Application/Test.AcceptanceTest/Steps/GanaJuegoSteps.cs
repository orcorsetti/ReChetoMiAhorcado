using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class GanaJuegoSteps
    {
        public IWebDriver WebDriver;

        [Given(@"the user enter her UserName ""(.*)"" and click the Login button")]
        public void GivenTheUserEnterHerUserNameAndClickTheLoginButton(string p0)
        {
            WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("https://ahorcadogrupo04.azurewebsites.net/Inicio.aspx?testMode=true");

            IWebElement txtBoxUserName = WebDriver.FindElement(By.Id("txtBoxUserName"));
            IWebElement btnLogin = WebDriver.FindElement(By.Id("btnLogin"));

            txtBoxUserName.SendKeys(p0);
            btnLogin.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#lblUserName")));
        }
        
        [Given(@"the user starts the game")]
        public void GivenTheUserStartsTheGame()
        {
            IWebElement btnStartGame = WebDriver.FindElement(By.Id("btnStartGame"));

            btnStartGame.Click();

            new WebDriverWait(WebDriver, TimeSpan.FromMinutes(1)).Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#txtBoxLetter")));
        }
        
        [Given(@"the user plays the correct letters")]
        public void GivenTheUserPlaysTheCorrectLetters(Table table)
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
        
        [Then(@"the user wins the game and the game congratulates her")]
        public void ThenTheUserWinsTheGameAndTheGameCongratulatesHer()
        {
            string lblGameResult = WebDriver.FindElement(By.CssSelector("#lblGameResult")).Text;

            Assert.AreEqual("Felicidades! Ganó en 6 intentos!", lblGameResult);
        }
    }
}
