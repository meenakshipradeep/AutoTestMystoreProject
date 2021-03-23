using Com.Test.Meenakshi.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

using TechTalk.SpecFlow.Assist;

namespace Com.Test.Meenakshi.Feature
{
    [Binding]
    public class UpdateMyNameSteps
    {
        Pages.LoginPage loginPage = null;

        Pages.MyAccountPage myAccountPage = null;
        [Given(@"I login into my App")]
        public void GivenILoginIntoMyApp()
        {
            // ScenarioContext.Current.Pending();
            OpenQA.Selenium.IWebDriver webdriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            webdriver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            loginPage = new LoginPage(webdriver);

            myAccountPage = new MyAccountPage(webdriver);
            Console.WriteLine("Given");

        }
        

        [When(@"I enter the following details and login")]
        public void WhenIEnterTheFollowingDetailsAndLogin(Table table)
        {
            //ScenarioContext.Current.Pending();
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.UserName, (string)data.Password);
            loginPage.ClickSigninButton();
        }


        [When(@"I update fisrtname and Passwords as below")]
        public void WhenIUpdateFisrtnameAndPasswordsAsBelow(Table table)
        {
            NUnit.Framework.Assert.That(myAccountPage.IsEmployeeDetailsExist());
            myAccountPage.ClickmyEmployeeDetails();
            dynamic data = table.CreateDynamicInstance();
            myAccountPage.updateUsername((string)data.firstname);
            myAccountPage.updatePwd((string)data.oldPassword, (string)data.newPassword);

            myAccountPage.ClickSaveButton();

        }



        [Then(@"firstname is successfully Updated")]
        public void ThenFirstnameIsSuccessfullyUpdated()
        {
            Thread.Sleep(1000);
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Then");

            NUnit.Framework.Assert.That(myAccountPage.alerttextUpdatedFirstNameExist());
            
        }
    }
}
