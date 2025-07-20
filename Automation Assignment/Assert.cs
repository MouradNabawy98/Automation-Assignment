using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Automation_Assignment
{
    public class Assert12
    {

#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        WebDriver driver;
#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        [OneTimeSetUp]
            public void OneTimeSetUp()
            {
                Console.WriteLine("Database Setup ....");
            }
            [SetUp]
            public void SetUp()
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/"); //base URL for the tests

            }
            [Test]
            public void login()
            {
                driver.FindElement(By.Id("username")).SendKeys("student");
                driver.FindElement(By.Id("password")).SendKeys("Password123");
                driver.FindElement(By.Id("submit")).Click();
                Assert.That(driver.FindElement(By.TagName("h1")).Text, Is.EqualTo("Logged In Successfully"));

            }
            [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }
            [OneTimeTearDown]
            public void OneTimeTearDown()
            {
                Console.WriteLine("Database Cleanup ....");
            }
        }
    }

