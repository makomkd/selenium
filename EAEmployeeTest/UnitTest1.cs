using System;
using EAEmployeeTest.Pages;
using EATestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        private string url = "https://phptravels.org/clientarea.php";

     

        [TestMethod]
        public void TestMethod1()
        {
            //ChromeDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(url);
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);

            Login();
        }

        public void Login()
        {

            LoginPage page = new LoginPage();

            page.Login("makomkd@gmail.com", "123456");

            page.ClickGlobe();
            

            MemberPage memPage = new MemberPage();

            memPage.InputSearch("123");

            //page.txtUsrName.SendKeys("makomkd@gmail.com");

            // page.txtPass.SendKeys("123456");

            // page.LoginBtn.Submit();

            // _driver.FindElement(By.ClassName("login")).Click();

            //UserName
            // _driver.FindElement(By.Id("inputEmail")).SendKeys("makomkd@gmail.com");

            //Password
            // _driver.FindElement(By.Id("inputPassword")).SendKeys("123456");

            // _driver.FindElement(By.Id("login")).Submit();



        }
    }
}
 