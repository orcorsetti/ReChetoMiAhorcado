using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Test.AcceptanceTest.Steps
{
    [Binding]
    public class PalabraCorrectaSteps
    {
        public IWebDriver weDriver { get; set; }

        [Given(@"the user enter a correct letter ""(.*)""")]
        public void GivenTheUserEnterACorrectLetter(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user clicked the play button")]
        public void WhenTheUserClickedThePlayButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the game show the letter ""(.*)"" where it belongs")]
        public void ThenTheGameShowTheLetterWhereItBelongs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
