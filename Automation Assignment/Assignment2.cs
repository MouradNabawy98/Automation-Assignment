﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Automation_Assignment
{
    public class Tests12
    {
        WebDriver driver;
        [SetUp]
        public void Setup()
        {
            // Initialize the ChromeDriver
            driver = new ChromeDriver();
        
        }

        [Test]
        public void Test12()
        {

             driver.Navigate().GoToUrl("https://www.dummyticket.com/dummy-ticket-for-visa-application/");
            // Locate elements by various selectors
            driver.Navigate().GoToUrl("https://aa-practice-test-automation.vercel.app/Pages/uploadFile.html");
            IWebElement uploadFileElement = driver.FindElement(By.Id("regularFileInput"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            // Upload a file
              driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            uploadFileElement.SendKeys("file.txt"); // Replace with the actual file path
            Console.WriteLine("File uploaded successfully.");
            driver.Navigate().GoToUrl("https://www.dummyticket.com/dummy-ticket-for-visa-application/");
            // Date Picker interaction
            IWebElement datePicker = driver.FindElement(By.Id("datepicker"));
            datePicker.Click();
            // Assuming the date picker allows you to select a date, month, and year
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 
             driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
               driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Find the button and print its tagName, attribute, and location/size
            IWebElement addButton = driver.FindElement(By.TagName("button"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Button Tag Name: " + addButton.TagName);
            Console.WriteLine("Button Class Attribute: " + addButton.GetAttribute("class"));
            Console.WriteLine("Button ID Attribute: " + addButton.GetAttribute("id"));
            Console.WriteLine("Button Location: " + addButton.Location);
            Console.WriteLine("Button Size: " + addButton.Size);
            Console.WriteLine("Is Button Enabled: " + addButton.Enabled);
            // Click the button to add an element
            addButton.Click();
            // Check if the checkbox is selected or not
            driver.Navigate().GoToUrl("https://aa-practice-test-automation.vercel.app/Pages/checkbox_Radio.html");
            IWebElement checkbox = driver.FindElement(By.Id("checkbox1"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Console.WriteLine("Is Checkbox Selected: " + checkbox.Selected);
            // Interact with a shadow DOM input field
            driver.Navigate().GoToUrl("https://books-pwakit.appspot.com/");
            IWebElement shadowHost = driver.FindElement(By.CssSelector("books-app"));
            shadowHost.GetShadowRoot().FindElement(By.CssSelector("input[placeholder='Search']")).SendKeys("Selenium");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           // Handle dynamic button with explicit WebDriverWait
             driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/2");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement dynamicButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("start")));
            dynamicButton.Click();
            IWebElement newWindowLink = driver.FindElement(By.LinkText("Click Here"));
            newWindowLink.Click();
            // Switch to the new window/tab
            string originalWindow = driver.CurrentWindowHandle;
            foreach (string windowHandle in driver.WindowHandles)
            {
                if (windowHandle != originalWindow)
                {
                    driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
            // Perform validation in the new window
            Console.WriteLine("New Window URL: " + driver.Url);
            Console.WriteLine("New Window Title: " + driver.Title);
            // Switch back to the original window
            driver.SwitchTo().Window(originalWindow);
            // Switch to a frame and type text into the editor
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.SwitchTo().Frame("mce_0_ifr");
            IWebElement editor = driver.FindElement(By.Id("tinymce"));
            editor.Clear();
            editor.SendKeys("This is a test text in the editor.");
            // Switch back to default content
            driver.SwitchTo().DefaultContent();
            // Print all text on the 4 frames
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/nested_frames");
            driver.SwitchTo().Frame("frame-top");
            driver.SwitchTo().Frame("frame-middle");
            IWebElement frameText = driver.FindElement(By.TagName("body"));
            Console.WriteLine("Text in Frame: " + frameText.Text);
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame("frame-left");
            IWebElement leftFrameText = driver.FindElement(By.TagName("body"));
            Console.WriteLine("Text in Left Frame: " + leftFrameText.Text);
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame("frame-right");
            IWebElement rightFrameText = driver.FindElement(By.TagName("body"));
            Console.WriteLine("Text in Right Frame: " + rightFrameText.Text);
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame("frame-bottom");
            IWebElement bottomFrameText = driver.FindElement(By.TagName("body"));
            Console.WriteLine("Text in Bottom Frame: " + bottomFrameText.Text);
       

        }
        [TearDown]
        public void TearDown()
        {
            // Close the browser
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
    
}
