using System;
using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {


//Added Chrome Driver, Can be Used for FireFox, IE and Safari
 IWebDriver driver = new ChromeDriver();
 Actions actions = new Actions(driver);

 //URL to access the webpage
 driver.Url = "https://www.visma.lv/";




//Clicking on the submit a presentation button
 driver.FindElement(By.ClassName("cta")).Click();

//Filling the input fields

//Entering Name in the text field
driver.FindElement(By.Id("edbfeb08-4870-42d2-8d81-aeb1a12a2aa2")).SendKeys("Test");

//Entering Surname
driver.FindElement(By.Id("f55aab27-4620-4b5f-9b7e-7c06549a78c1")).SendKeys("Test");

//Entering Organization Name
driver.FindElement(By.Id("73527c0b-cf42-4423-bc0c-2bab7b7e2fc6")).SendKeys("Test Pvt. Ltd.");

//Entering Phone Number
driver.FindElement(By.Id("e26b761e-46c5-466a-9e29-834d22c8050a")).SendKeys("12312312323");

//Entering Email
driver.FindElement(By.Id("1bc90f14-3d36-4402-a4b6-7573f738e394")).SendKeys("Test@gmail.com");


//Checking required checkbox for agreement
driver.FindElement(By.Id("44f7d82f-7015-456f-8767-3a974559c21b_profiling")).Click();

//Submitting the form

driver.FindElement(By.Name("submit")).Click();

System.Threading.Thread.Sleep(3000);

driver.FindElement(By.ClassName("logo")).Click();


//Scrolling to the Social Blog posts so that It becomes clickable
var element = driver.FindElement(By.CssSelector("a.col-10"));
actions.MoveToElement(element);
element.Click();


//handling different tabs of browser and closing each tab after verifying social links
var tabs = driver.WindowHandles; 
if (tabs.Count > 1) { 
    driver.SwitchTo().Window(tabs[1]); 
    System.Threading.Thread.Sleep(10000);
    driver.Close(); 
    driver.SwitchTo().Window(tabs[0]);
     }


driver.FindElement(By.ClassName("prevent_tracking")).Click();

//Verifying Social Link for Facebook
driver.FindElement(By.PartialLinkText("Facebook")).Click();


//handling different tabs of browser and closing each tab after verifying social links
var tabs1 = driver.WindowHandles; 
if (tabs1.Count > 1) { 
    driver.SwitchTo().Window(tabs1[1]); 
    System.Threading.Thread.Sleep(5000);
    driver.Close(); 
    driver.SwitchTo().Window(tabs1[0]);
     }

//Verifying Social Link for LinkedIn
driver.FindElement(By.PartialLinkText("LinkedIn")).Click();


//handling different tabs of browser and closing each tab after verifying social links
var tabs2 = driver.WindowHandles; 
if (tabs2.Count > 1) { 
    driver.SwitchTo().Window(tabs2[1]); 
    System.Threading.Thread.Sleep(5000);
    driver.Close(); 
    driver.SwitchTo().Window(tabs2[0]);
     }


//Verifying Social Link for Blogs page
driver.FindElement(By.PartialLinkText("Blog")).Click();

//handling different tabs of browser and closing each tab after verifying social links
var tabs3 = driver.WindowHandles; 
if (tabs3.Count > 1) { 
    driver.SwitchTo().Window(tabs3[1]); 
    System.Threading.Thread.Sleep(5000);
    driver.Close(); 
    driver.SwitchTo().Window(tabs3[0]);
     }     

//Selecting the country chooser dropdown after scrolling to it
var elementb = driver.FindElement(By.Id("countrychooser"));
actions.MoveToElement(elementb);
elementb.Click();


//Using Select Element to access the dropdown which requires you to open and then click
SelectElement elementc = new SelectElement( driver.FindElement(By.ClassName("countries")));
 System.Threading.Thread.Sleep(3000);
elementc.SelectByIndex(2);

//You can Assert at the end if required to confirm all scenarios

//IWebElement body = driver.FindElement(By.TagName("body"));
//Assert.IsTrue(body.Text.Contains("Paldies!"));

        }
    }
}
