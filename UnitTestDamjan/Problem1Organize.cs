using System;
using System.Threading;
using Hanssens.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestDamjan
{
    [TestClass]
    public class Problem1Organize
    {
        [TestMethod]
        public void ConfirmResultValue()
        {
            //Get selectors
            By problemOrganize = By.CssSelector("#ftco-nav > ul > li:nth-child(2) > a");
            By organizerName = By.XPath("//*[@id='name']");
            By birthdayName = By.CssSelector("input[class='form-control bp']");
            By age = By.Id("age");
            By when = By.Id("date");
            By time = By.Id("time");
            By persons21 = By.CssSelector("#persons > option:nth-child(5)");
            By persons11 = By.CssSelector("#persons > option:nth-child(4)");
            By alergiesNo = By.Id("alg_n");
            By alergiesYes = By.Id("alg_y");
            By wallnutsAlergies = By.Id("alg1");
            By chestnutsAlergies = By.Id("alg2");
            By btnOrganize = By.CssSelector("body > section.ftco-section.ftco-no-pt.ftco-no-pb > div > div > div.col-md-7.ftco-animate.makereservation.p-4.p-md-5.fadeInUp.ftco-animated > form > div > div.col-md-12.mt-3 > div > p > a");
            By confirmOrganizerName = By.Id("orr");
            By confirmBirthdayName = By.Id("cbr");
            By confirmAge = By.Id("agr");
            By confirmWhen = By.Id("dtr");
            By confirmTime = By.Id("tmr");
            By confirmPersons = By.Id("gur");
            By confirmAlergies = By.Id("alr");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;
            int waitingTime = 1000;
            webDriver.FindElement(problemOrganize).Click();
            Thread.Sleep(waitingTime);

            //Enter value in input
            webDriver.FindElement(organizerName).SendKeys("Maja");
            webDriver.FindElement(birthdayName).SendKeys("Nikola");
            webDriver.FindElement(age).SendKeys("38");
            webDriver.FindElement(when).SendKeys("05/20/2023");
            webDriver.FindElement(time).SendKeys("08:00PM");
            webDriver.FindElement(persons21).Click();
            webDriver.FindElement(alergiesNo).Click();

            //Comfirm save metod
            webDriver.FindElement(btnOrganize).Click();
            Thread.Sleep(waitingTime);
            string expectedOrganizerName = "Maja";
            var actualOrganizerName = webDriver.FindElement(confirmOrganizerName);
            Assert.IsTrue(actualOrganizerName.Text.Equals(expectedOrganizerName));

            string expectedBirthdayName = "Nikola";
            var actualBirthdayName = webDriver.FindElement(confirmBirthdayName);
            Assert.IsTrue(actualBirthdayName.Text.Equals(expectedBirthdayName));

            string expectedAge = "38";
            var actualAge = webDriver.FindElement(confirmAge);
            Assert.IsTrue(actualAge.Text.Equals(expectedAge));

            string expectedWhen = "2023-05-20";
            var actualWhen = webDriver.FindElement(confirmWhen);
            Assert.IsTrue(actualWhen.Text.Equals(expectedWhen));

            string expectedTime = "20:00";
            var actualTime = webDriver.FindElement(confirmTime);
            Assert.IsTrue(actualTime.Text.Equals(expectedTime));

            string expectedPersons = "21+";
            var actualPersons = webDriver.FindElement(confirmPersons);
            Assert.IsTrue(actualPersons.Text.Equals(expectedPersons));

            string expectedAlergies = "No";
            var actualAlergies = webDriver.FindElement(confirmAlergies);
            Assert.IsTrue(actualAlergies.Text.Equals(expectedAlergies));

            webDriver.Close();
        }
        [TestMethod]
        public void ConfirmLocalStorageSave()
        {
            //Get selectors
            By problemOrganize = By.CssSelector("#ftco-nav > ul > li:nth-child(2) > a");
            By organizerName = By.XPath("//*[@id='name']");
            By birthdayName = By.CssSelector("input[class='form-control bp']");
            By age = By.Id("age");
            By when = By.Id("date");
            By time = By.Id("time");
            By persons21 = By.CssSelector("#persons > option:nth-child(5)");
            By persons11 = By.CssSelector("#persons > option:nth-child(4)");
            By alergiesMaybe = By.Id("alg_m");
            By alergiesYes = By.Id("alg_y");
            By wallnutsAlergies = By.Id("alg1");
            By chestnutsAlergies = By.Id("alg2");
            By btnOrganize = By.CssSelector("body > section.ftco-section.ftco-no-pt.ftco-no-pb > div > div > div.col-md-7.ftco-animate.makereservation.p-4.p-md-5.fadeInUp.ftco-animated > form > div > div.col-md-12.mt-3 > div > p > a");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;
            int waitingTime = 1000;
            webDriver.FindElement(problemOrganize).Click();
            Thread.Sleep(waitingTime);

            //Enter value in input and compare with local storage
            webDriver.FindElement(organizerName).SendKeys("Maja");
            webDriver.FindElement(birthdayName).SendKeys("Nikola");
            webDriver.FindElement(age).SendKeys("3");
            webDriver.FindElement(when).SendKeys("05/23/2023");
            webDriver.FindElement(time).SendKeys("08:20PM");
            webDriver.FindElement(persons11).Click();
            webDriver.FindElement(alergiesMaybe).Click();
            webDriver.FindElement(chestnutsAlergies).Click();

            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Organizer')"), "Maja");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Birthday_Person')"), "Nikola");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Age')"), "3");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Date')"), "2023-05-23");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Time')"), "20:20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Number_Of_People')"), "11-20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergy')"), "Maybe");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergies')"), "Chestnuts");

            webDriver.Close();
        }
        [TestMethod]
        public void PassedLocalStorageChanges()
        {
            //Get selectors
            By problemOrganize = By.CssSelector("#ftco-nav > ul > li:nth-child(2) > a");
            By organizerName = By.XPath("//*[@id='name']");
            By birthdayName = By.CssSelector("input[class='form-control bp']");
            By age = By.Id("age");
            By when = By.Id("date");
            By time = By.Id("time");
            By persons21 = By.CssSelector("#persons > option:nth-child(5)");
            By persons11 = By.CssSelector("#persons > option:nth-child(4)");
            By alergiesMaybe = By.Id("alg_m");
            By alergiesYes = By.Id("alg_y");
            By wallnutsAlergies = By.Id("alg1");
            By chestnutsAlergies = By.Id("alg2");
            By btnOrganize = By.CssSelector("body > section.ftco-section.ftco-no-pt.ftco-no-pb > div > div > div.col-md-7.ftco-animate.makereservation.p-4.p-md-5.fadeInUp.ftco-animated > form > div > div.col-md-12.mt-3 > div > p > a");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;
            int waitingTime = 1000;
            webDriver.FindElement(problemOrganize).Click();
            Thread.Sleep(waitingTime);

            //Enter value in input and compare with local storage
            webDriver.FindElement(organizerName).SendKeys("Maja" + Keys.Tab);
            webDriver.FindElement(birthdayName).SendKeys("Nikola" + Keys.Tab);
            webDriver.FindElement(age).SendKeys("3" + Keys.Tab);
            webDriver.FindElement(when).SendKeys("05/23/2023" + Keys.Tab);
            webDriver.FindElement(time).SendKeys("08:20PM" + Keys.Tab);
            webDriver.FindElement(persons11).Click();
            webDriver.FindElement(alergiesMaybe).Click();
            webDriver.FindElement(chestnutsAlergies).Click();

            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Organizer')"), "Maja");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Birthday_Person')"), "Nikola");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Age')"), "3");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Date')"), "2023-05-23");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Time')"), "20:20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Number_Of_People')"), "11-20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergy')"), "Maybe");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergies')"), "Chestnuts");



            webDriver.FindElement(organizerName).SendKeys(" Radovic");
            webDriver.FindElement(birthdayName).SendKeys(" Radovic");
            webDriver.FindElement(age).SendKeys("8");
            webDriver.FindElement(when).SendKeys("05/20/2023");
            webDriver.FindElement(time).Clear();
            webDriver.FindElement(persons21).Click();
            webDriver.FindElement(time).SendKeys("08:00PM");
            webDriver.FindElement(alergiesYes).Click();
            webDriver.FindElement(wallnutsAlergies).Click();

            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Organizer')"), "Maja Radovic");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Birthday_Person')"), "Nikola Radovic");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Age')"), "38");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Date')"), "2023-05-20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Time')"), "20:00");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Number_Of_People')"), "21+");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergy')"), "Yes");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergies')"), "Chestnuts,Wallnuts");

            webDriver.Close();
        }
        [TestMethod]
        public void FailedLocalStorageChanges()
        {
            //Get selectors
            By problemOrganize = By.CssSelector("#ftco-nav > ul > li:nth-child(2) > a");
            By organizerName = By.XPath("//*[@id='name']");
            By birthdayName = By.CssSelector("input[class='form-control bp']");
            By age = By.Id("age");
            By when = By.Id("date");
            By time = By.Id("time");
            By persons21 = By.CssSelector("#persons > option:nth-child(5)");
            By persons11 = By.CssSelector("#persons > option:nth-child(4)");
            By alergiesMaybe = By.Id("alg_m");
            By alergiesNo = By.Id("alg_n");
            By chestnutsAlergies = By.Id("alg2");
            By btnOrganize = By.CssSelector("body > section.ftco-section.ftco-no-pt.ftco-no-pb > div > div > div.col-md-7.ftco-animate.makereservation.p-4.p-md-5.fadeInUp.ftco-animated > form > div > div.col-md-12.mt-3 > div > p > a");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;
            int waitingTime = 1000;
            webDriver.FindElement(problemOrganize).Click();
            Thread.Sleep(waitingTime);

            //Enter value in input and compare with local storage
            webDriver.FindElement(organizerName).SendKeys("Maja" + Keys.Tab);
            webDriver.FindElement(birthdayName).SendKeys("Nikola" + Keys.Tab);
            webDriver.FindElement(age).SendKeys("3" + Keys.Tab);
            webDriver.FindElement(when).SendKeys("05/23/2023" + Keys.Tab);
            webDriver.FindElement(time).SendKeys("08:20PM" + Keys.Tab);
            webDriver.FindElement(persons11).Click();
            webDriver.FindElement(alergiesMaybe).Click();
            webDriver.FindElement(chestnutsAlergies).Click();

            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Organizer')"), "Maja");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Birthday_Person')"), "Nikola");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Age')"), "3");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Date')"), "2023-05-23");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Time')"), "20:20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Number_Of_People')"), "11-20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergy')"), "Maybe");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergies')"), "Chestnuts");



            webDriver.FindElement(organizerName).SendKeys(" Radovic");
            webDriver.FindElement(birthdayName).SendKeys(" Radovic");
            webDriver.FindElement(age).SendKeys("8");
            webDriver.FindElement(when).SendKeys("05/20/2023");
            webDriver.FindElement(time).Clear();
            webDriver.FindElement(persons21).Click();
            webDriver.FindElement(time).SendKeys("08:00PM");
            webDriver.FindElement(alergiesNo).Click();

            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Organizer')"), "Maja Radovic");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Birthday_Person')"), "Nikola Radovic");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Age')"), "38");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Date')"), "2023-05-20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Time')"), "20:00");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Number_Of_People')"), "21+");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergy')"), "No");
            Assert.AreNotEqual((String)jse.ExecuteScript("return localStorage.getItem('alergies')"), "Chestnuts");
        }
        [TestMethod]
        public void FailedLocalStorageChangesSameSheckboxDoubleClick()
        {
            //Get selectors
            By problemOrganize = By.CssSelector("#ftco-nav > ul > li:nth-child(2) > a");
            By organizerName = By.XPath("//*[@id='name']");
            By birthdayName = By.CssSelector("input[class='form-control bp']");
            By age = By.Id("age");
            By when = By.Id("date");
            By time = By.Id("time");
            By persons21 = By.CssSelector("#persons > option:nth-child(5)");
            By persons11 = By.CssSelector("#persons > option:nth-child(4)");
            By alergiesMaybe = By.Id("alg_m");
            By alergiesYes = By.Id("alg_y");
            By chestnutsAlergies = By.Id("alg2");
            By wallnutsAlergies = By.Id("alg1");
            By btnOrganize = By.CssSelector("body > section.ftco-section.ftco-no-pt.ftco-no-pb > div > div > div.col-md-7.ftco-animate.makereservation.p-4.p-md-5.fadeInUp.ftco-animated > form > div > div.col-md-12.mt-3 > div > p > a");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;
            int waitingTime = 1000;
            webDriver.FindElement(problemOrganize).Click();
            Thread.Sleep(waitingTime);

            //Enter value in input and compare with local storage
            webDriver.FindElement(organizerName).SendKeys("Maja" + Keys.Tab);
            webDriver.FindElement(birthdayName).SendKeys("Nikola" + Keys.Tab);
            webDriver.FindElement(age).SendKeys("3" + Keys.Tab);
            webDriver.FindElement(when).SendKeys("05/23/2023" + Keys.Tab);
            webDriver.FindElement(time).SendKeys("08:20PM" + Keys.Tab);
            webDriver.FindElement(persons11).Click();
            webDriver.FindElement(alergiesMaybe).Click();
            webDriver.FindElement(chestnutsAlergies).Click();

            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Organizer')"), "Maja");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Birthday_Person')"), "Nikola");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Age')"), "3");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Date')"), "2023-05-23");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Time')"), "20:20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Number_Of_People')"), "11-20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergy')"), "Maybe");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergies')"), "Chestnuts");



            webDriver.FindElement(organizerName).SendKeys(" Radovic");
            webDriver.FindElement(birthdayName).SendKeys(" Radovic");
            webDriver.FindElement(age).SendKeys("8");
            webDriver.FindElement(when).SendKeys("05/20/2023");
            webDriver.FindElement(time).Clear();
            webDriver.FindElement(persons21).Click();
            webDriver.FindElement(time).SendKeys("08:00PM");
            webDriver.FindElement(alergiesYes).Click();
            webDriver.FindElement(chestnutsAlergies).Click();
            webDriver.FindElement(wallnutsAlergies).Click();

            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Organizer')"), "Maja Radovic");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Birthday_Person')"), "Nikola Radovic");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Age')"), "38");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Date')"), "2023-05-20");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Time')"), "20:00");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('Number_Of_People')"), "21+");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergy')"), "Yes");
            Assert.AreEqual((String)jse.ExecuteScript("return localStorage.getItem('alergies')"), "Wallnuts");

        }
    }
}
