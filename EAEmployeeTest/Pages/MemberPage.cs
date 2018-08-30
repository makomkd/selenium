using EATestProject.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class MemberPage : BasePage
    {

        //public RemoteWebDriver Driver { get; set; }

        ///IWebElement lnkGlobe => Driver.FindElement(By.Id("CtrlAdminMenu1_lnkFieldSettings"));

        
       // IWebElement txtLnk => Driver.FindElement(By.ClassName("ContentPlaceHolder1_chkDetail_0_1008_1007"));

        [FindsBy(How = How.ClassName, Using = "form-control input-sm")]
        public IWebElement SearchTxt { get; set; }


        public void InputSearch(string input)
        {
            SearchTxt.SendKeys(input);

        }
    }
}
