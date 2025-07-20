using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Automation_Assignment
{
    public class Assignement3_4
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
            [Test ,Order(2)]
        [Category ("Valid Login")]
            public void Validlogin()
            {
                driver.FindElement(By.Id("username")).SendKeys("student");
                driver.FindElement(By.Id("password")).SendKeys("Password123");
                driver.FindElement(By.Id("submit")).Click();
                Assert.That(driver.FindElement(By.TagName("h1")).Text, Is.EqualTo("Logged In Successfully"));

            }
        [Test, Order(1)]
        [Category ("Invaild Login")]
        public void inValidlogin()
        {
            driver.FindElement(By.Id("username")).SendKeys("student");
            driver.FindElement(By.Id("password")).SendKeys("Password124");
            driver.FindElement(By.Id("submit")).Click();
            string tt = driver.FindElement(By.Id("error")).Text;
            Console.WriteLine(tt);
            Assert.True(driver.FindElement(By.Id("error")).Text.Contains("Your password is invalid!"));

        }
        [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }
        }
    }

