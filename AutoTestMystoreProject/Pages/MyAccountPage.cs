using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Test.Meenakshi.Pages
{
    class MyAccountPage
    {
        public OpenQA.Selenium.IWebDriver WebDriver { get; }
        public MyAccountPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.XPath("//span[contains(.,'My personal information')]"));
        public IWebElement alerttextUpdatedFirstName => WebDriver.FindElement(By.XPath("//*[@id='center_column']/div/p/[contains(.,'Your personal information has been successfully updated.')]"));

        public bool alerttextUpdatedFirstNameExist() => alerttextUpdatedFirstName.Displayed;

        public bool IsEmployeeDetailsExist() => lnkEmployeeDetails.Displayed;
        public IWebElement txtfirstname => WebDriver.FindElement(By.Name("firstname"));
        public IWebElement btnMyPersonalInformation => WebDriver.FindElement(By.Name("submitIdentity"));

        public IWebElement txtoldPwd => WebDriver.FindElement(By.Name("old_passwd"));
        public IWebElement txtnewPwd => WebDriver.FindElement(By.Name("passwd"));

        public IWebElement txtconfnewPwd => WebDriver.FindElement(By.Name("confirmation"));
        public void updateUsername(string firstname)
        {
            txtfirstname.Clear();
                     txtfirstname.SendKeys(firstname);
       
        }
        public void updatePwd(string oldPwd, string newPwd)
        {
            txtoldPwd.SendKeys(oldPwd);
            txtnewPwd.SendKeys(newPwd);
            txtconfnewPwd.SendKeys(newPwd);
        }
        public void ClickmyEmployeeDetails() => lnkEmployeeDetails.Click();
        public void ClickSaveButton() => btnMyPersonalInformation.Submit();
    }
}
