using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using System;

namespace SeleniumWebdriver
{
    public class LoginPage : PageBase
    {
        private IWebDriver _driver;
      
        #region WebElement
        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement UsernameTextBox;



        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement PassTextBox;

        [FindsBy(How = How.Id, Using = "btn-action")]
        [CacheLookup]
        private IWebElement LoginButton;


        #endregion


        public LoginPage(IWebDriver _driver) : base(_driver)
        {
            this._driver = _driver;
        }

      
        #region Actions
        public void Login(string username, string password)
        {
            UsernameTextBox.SendKeys(username);
            PassTextBox.SendKeys(password);

        }

        #endregion

        public void ErrorMessage()
        {
            GenericHelper.WaitForWebElementInPage(By.ClassName("error_button"), TimeSpan.FromSeconds(30));
        }

        #region Navigation
        public void ClickLogin()
        {
            LoginButton.Click();
    
        }

        public HomePage NavigateHomePage()
        {
            return new HomePage(_driver);

        }
        #endregion
    }

}
