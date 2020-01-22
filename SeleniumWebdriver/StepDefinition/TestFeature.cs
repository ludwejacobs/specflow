using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;

using SeleniumWebdriver.Settings;
using TechTalk.SpecFlow;


namespace SeleniumWebdriver.StepDefinition
{
    [Binding]
    public sealed class TestFeature
    {
        private HomePage hPage;
        private LoginPage lPage;

        #region Given

        [Given(@"the LoginPage is open")]
        public void GivenTheLoginPageIsOpen()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }
       



        [Given(@"the login page  message is present")]
        public void GivenTheLoginPageMessageIsPresent()
        {                                                     
         AssertHelper.AreEqual("login-logo", lPage.Title);
        }

        //    [Given(@"the ""(.*)"" is open")]
        //   public void GivenTheIsOpen()
        //   {
        //       lPage.NavigateHomePage();
        //   }



        #endregion

        #region When
        [When(@"the user fills in the ""(.*)"" and ""(.*)""\.")]
        public void WhenTheUserFillsInTheAnd_(string username, string password, Table table)
        {
            lPage.Login(username, password);
        }



        //[When(@"the user fills in their username and password.")]
        //   public void WhenTheUserFillsInCredintials(string username, string password, Table table)
        //  {
        // lPage.Login(username, password);
        //  }

        #endregion

        #region Then
        [Then(@"the ""(.*)"" message is displayed")]
        public void ThenTheErrorMessageIsDisplayed()
        {
            lPage.ErrorMessage();
        }
        [Then(@"the user clicks the login button")]
        
        
        public void ThenTheUserClicksTheLoginButton()
        {
            lPage.ClickLogin();
        }


        [Given(@"the page ""(.*)"" message is present")]
        public void GivenThePageMessageIsPresent()
        {
            AssertHelper.AreEqual("login-logo", hPage.Title);
        }


        #endregion




    }
}
