using System.Drawing;
using NUnit.Framework.Internal;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_Assignment
{
    public class Tests
    {
       WebDriver driver;
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://example.com");
            Console.WriteLine("Current URL: " + driver.Url);
            Console.WriteLine("Page Title: " + driver.Title);
            Console.WriteLine("HTML Source Code: " + driver.PageSource);
            Console.WriteLine("Unique ID of the current browser window: " + driver.CurrentWindowHandle);
            driver.Navigate().GoToUrl("https://www.selenium.dev");
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();
            Console.WriteLine("Current Window Size: " + driver.Manage().Window.Size);
            Console.WriteLine("Current Window Position: " + driver.Manage().Window.Position);
            driver.Manage().Window.Size = new Size(1024, 768);
            driver.Manage().Window.Position = new Point(200, 150);
            driver.Manage().Window.Maximize();
            driver.Manage().Window.FullScreen();
            driver.Close();
            driver.Quit();
        }

        public void Test2()
        {
            /**Open a 'https://www.facebook.com/r.php?entry_point=login'   and locate fields by id, name, className, tagName, xpath, and cssSelector. Fill in test data.
             */
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/r.php?entry_point=login");
            // Locate elements by various selectors
            IWebElement firstNameField = driver.FindElement(By.Id("u_0_m"));
            IWebElement lastNameField = driver.FindElement(By.Name("lastname"));
            IWebElement emailField = driver.FindElement(By.ClassName("inputtext"));
            IWebElement passwordField = driver.FindElement(By.TagName("input"));
            IWebElement submitButton = driver.FindElement(By.XPath("//button[@name='websubmit']"));
            IWebElement cssSelectorField = driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            // Fill in test data
            firstNameField.SendKeys("TestFirstName");
            lastNameField.SendKeys("TestLastName");
        }
    }
}