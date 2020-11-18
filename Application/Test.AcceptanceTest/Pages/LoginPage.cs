using OpenQA.Selenium;

namespace Test.AcceptanceTest.Pages
{
    public class LoginPage
    {
        public IWebDriver WebDriver { get; } 

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI Elements
        public IWebElement linkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtBoxUserName => WebDriver.FindElement(By.Name("txtBoxUserName"));
        public IWebElement btnLogin => WebDriver.FindElement(By.Name("btnLogin"));
        public IWebElement linkMenu => WebDriver.FindElement(By.LinkText("Menu"));

        public void ClickLogin() => linkLogin.Click();

        public void Login(string userName)
        {
            txtBoxUserName.SendKeys(userName);
        }

        public bool IsLoginCorrect(string userName)
        {
            bool menuDisplayed = linkMenu.Displayed;
            string userNameDisplayed = WebDriver.FindElement(By.Name("lblUserName")).Text;

            if( userNameDisplayed==userName && menuDisplayed == true)
            {
                return true;
            }
            return false;
        }

    }
}
