using OpenQA.Selenium;
using SwagProject.Driver;

namespace SwagProject.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement UserName => driver.FindElement(By.Id("user-name"));

        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement ButtonLogin => driver.FindElement(By.Id("login-button"));
        //public IWebElement UserNotLogin => driver.FindElement(By.CssSelector(".text-danger"));

        public void Login(string name, string pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            ButtonLogin.Submit();
        }
    }
}
