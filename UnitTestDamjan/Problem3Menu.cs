using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestDamjan
{
    [TestClass]
    public class Problem3Menu
    {
        [TestMethod]
        public void CorectTotalClickedSlowly()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(4) > a");
            By Stuffed17 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div.text > button");
            By Chicken29 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(3) > div.text > button");
            By Breaded12 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div.text > button");
            By Skewered10 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(5) > div.text > button");
            By Mussels30 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(6) > div.text > button");
            By Catfish18 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(7) > div.text > button");
            By Mango12 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(8) > div.text > button");
            By Beef15 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(9) > div.text > button");
            By Pancakes5 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div.text > button");
            By Stawberry3 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(3) > div.text > button");
            By Chocolate6 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(4) > div.text > button");
            By Malaga2 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(5) > div.text > button");
            By Baklava10 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(6) > div.text > button");
            By total = By.Id("ukupno");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            int waitingTime = 3000;
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 200);");
            webDriver.FindElement(Stuffed17).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 200);");
            webDriver.FindElement(Chicken29).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 200);");
            webDriver.FindElement(Breaded12).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Skewered10).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Mussels30).Click();
            jse.ExecuteScript("window.scrollBy(0, 100);");
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Catfish18).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Mango12).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Beef15).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, -800);");
            webDriver.FindElement(Pancakes5).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Stawberry3).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Chocolate6).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Malaga2).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Baklava10).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(Baklava10).Click();
            Thread.Sleep(waitingTime);

            string expectedResult = "179";
            var actualResult = webDriver.FindElement(total);
            Thread.Sleep(waitingTime);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }
        [TestMethod]
        public void WrongTotalClickedFast()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(4) > a");
            By Stuffed17 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div.text > button");
            By Chicken29 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(3) > div.text > button");
            By Breaded12 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div.text > button");
            By Skewered10 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(5) > div.text > button");
            By Mussels30 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(6) > div.text > button");
            By Catfish18 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(7) > div.text > button");
            By Mango12 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(8) > div.text > button");
            By Beef15 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(9) > div.text > button");
            By Pancakes5 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div.text > button");
            By Stawberry3 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(3) > div.text > button");
            By Chocolate6 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(4) > div.text > button");
            By Malaga2 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(5) > div.text > button");
            By Baklava10 = By.CssSelector("body > section.ftco-section > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(6) > div.text > button");
            By total = By.Id("ukupno");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            int waitingTime = 300;
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 200);");
            webDriver.FindElement(Stuffed17).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 200);");
            webDriver.FindElement(Chicken29).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 200);");
            webDriver.FindElement(Breaded12).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Skewered10).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Mussels30).Click();
            jse.ExecuteScript("window.scrollBy(0, 100);");
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Catfish18).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Mango12).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Beef15).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, -800);");
            webDriver.FindElement(Pancakes5).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Stawberry3).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Chocolate6).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Malaga2).Click();
            Thread.Sleep(waitingTime);
            jse.ExecuteScript("window.scrollBy(0, 100);");
            webDriver.FindElement(Baklava10).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(Baklava10).Click();
            Thread.Sleep(waitingTime);

            string expectedResult = "179";
            var actualResult = webDriver.FindElement(total);
            Thread.Sleep(waitingTime);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

        }
    }
}
