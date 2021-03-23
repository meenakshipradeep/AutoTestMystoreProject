using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Test.Meenakshi.Pages
{
    class LoginPage
    {
        public OpenQA.Selenium.IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;               
        }
        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtuserName => WebDriver.FindElement(By.Name("email"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Name("passwd"));
        public IWebElement btnLogin => WebDriver.FindElement(By.Id("SubmitLogin"));

        public void ClickLogin() => lnkLogin.Click();

        public void Login(string userName, string Password)
        {
            txtuserName.SendKeys(userName);
            txtPassword.SendKeys(Password);
        }
        public void ClickSigninButton() => btnLogin.Submit();

    }
}
