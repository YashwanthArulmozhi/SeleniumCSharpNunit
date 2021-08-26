using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWithCSharp
{
    class LoginPage
    {


        CommonActionClass commonActions = new CommonActionClass();

        IWebDriver driver;


        String applicationUrl = "http://thedemosite.co.uk/login.php";
        String userName = "TestUser1";
        string password = "Test123";

        private By link_AddUser = By.XPath("//a[contains(text(),'Add a User')]");
        private By input_EmailId = By.Name("username");
        private By input_Password = By.Name("password");
        private By button_Save = By.XPath("//input[@value='save']");
        private By label_Details = By.XPath("//b[text()='The username:']/..");
        private By link_Login = By.XPath("(//a[@href='login.php'])[1]");

        public void CreateUserValidation()
        {
            commonActions.LaunchApplication("chrome", applicationUrl);
            if (commonActions.WaitFromElement(link_AddUser) != null)
            {
                commonActions.ClickElement(link_AddUser);
                if (commonActions.WaitFromElement(input_EmailId) != null)
                {
                    commonActions.SendValue(input_EmailId, userName);
                    commonActions.SendValue(input_Password, password);
                    commonActions.ClickElement(button_Save);
                }
                if (commonActions.WaitFromElement(label_Details) != null)
                {
                    string data = commonActions.GetTextValue(label_Details);
                    Console.WriteLine("Data in UI - > " + data);
                }
            }
        }



        public void CloseDriver()
        {
            commonActions.CloseBrowser();
        }
    }
}
