using EATestProject.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class LoginPage: BasePage

    {
        
       

        //public static RemoteWebDriver Driver { get => _driver; set => _driver = value; }

        //IWebElement LoginBtn => _driver.FindElement(By.Id("login"));
       // IWebElement txtUsrName => _driver.FindElement(By.Id("inputEmail"));
       // IWebElement txtPass => _driver.FindElement(By.Id("inputPassword"));


               
        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement LoginBtn { get; set; }

        [FindsBy(How = How.Id, Using = "inputEmail")]
        public IWebElement txtUsrName { get; set; }

        [FindsBy(How = How.Id, Using = "inputPassword")]
        public IWebElement txtPass { get; set; }

        [FindsBy(How = How.Id, Using = "CtrlAdminMenu1_lnkFieldSettings")]
        public IWebElement LnkGlobe { get; set; }


        public void Login(string userName, string password)
        {
            txtUsrName.SendKeys(userName);
            txtPass.SendKeys(password);
            LoginBtn.Submit();
        }

        public MemberPage ClickGlobe()
        {
            LnkGlobe.Click();
            return new MemberPage();
        }
    }

}
