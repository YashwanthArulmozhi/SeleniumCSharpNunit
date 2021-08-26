using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp
{
    class SeleniumTest
    {

        LoginPage loginPage = new LoginPage();

        static void Main()
        {
            Console.WriteLine("Execution Started..");
        }

        [Test]
        public void RunTest()
        {
            loginPage.CreateUserValidation();  
        }

       /* [TearDown]
        public void CloseBrowser()
        {
            loginPage.CloseDriver();
        }*/
    }
}
