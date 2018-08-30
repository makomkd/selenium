using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EATestProject.Base
{
    public abstract class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
