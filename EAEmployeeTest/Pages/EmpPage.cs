using EATestProject.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class EmpPage: DriverContext
    {

        IWebElement lnkGlobe => _driver.FindElement(By.Id("CtrlAdminMenu1_lnkFieldSettings"));

        //[FindsBy(How = How.Id, Using = "CtrlAdminMenu1_lnkFieldSettings")]
        //public IWebElement lnkGlobe { get; set; }

        IWebElement txtLnk => _driver.FindElement(By.ClassName("ContentPlaceHolder1_chkDetail_0_1008_1007"));

        //[FindsBy(How = How.ClassName, Using = "ContentPlaceHolder1_chkDetail_0_1008_1007")]
       // public IWebElement txtLnk { get; set; }
    }
}
