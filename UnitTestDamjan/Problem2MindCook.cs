using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestDamjan
{
    [TestClass]
    public class Problem2MindCook
    {
        [TestMethod]
        public void GetAvocadoBenedict0()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(winter).Click();
            webDriver.FindElement(coffee).Click();
            webDriver.FindElement(black).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(salty).Click();
            webDriver.FindElement(hot).Click();
            webDriver.FindElement(fork).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(shallow).Click();
            webDriver.FindElement(vegetables).Click();
            webDriver.FindElement(beer).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Avocado Benedict";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }
        [TestMethod]
        public void GetAvocadoBenedict1()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(winter).Click();
            webDriver.FindElement(coffee).Click();
            webDriver.FindElement(black).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(salty).Click();
            webDriver.FindElement(hot).Click();
            webDriver.FindElement(fork).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(shallow).Click();
            webDriver.FindElement(vegetables).Click();
            webDriver.FindElement(cocktail).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Avocado Benedict";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }

        [TestMethod]
        public void GetStrawberrySundae2()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(winter).Click();
            webDriver.FindElement(coffee).Click();
            webDriver.FindElement(black).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(salty).Click();
            webDriver.FindElement(hot).Click();
            webDriver.FindElement(fork).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(shallow).Click();
            webDriver.FindElement(fruit).Click();
            webDriver.FindElement(cocktail).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Strawberry Sundae";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }
        [TestMethod]
        public void GetStrawberrySundae3()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(winter).Click();
            webDriver.FindElement(coffee).Click();
            webDriver.FindElement(black).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(salty).Click();
            webDriver.FindElement(hot).Click();
            webDriver.FindElement(fork).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(deep).Click();
            webDriver.FindElement(fruit).Click();
            webDriver.FindElement(cocktail).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Strawberry Sundae";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }
        [TestMethod]
        public void GetSoySalmon4()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(winter).Click();
            webDriver.FindElement(coffee).Click();
            webDriver.FindElement(black).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(salty).Click();
            webDriver.FindElement(hot).Click();
            webDriver.FindElement(spoon).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(deep).Click();
            webDriver.FindElement(fruit).Click();
            webDriver.FindElement(cocktail).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Soy Salmon";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }
        [TestMethod]
        public void GetSoySalmon5()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(winter).Click();
            webDriver.FindElement(coffee).Click();
            webDriver.FindElement(black).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(salty).Click();
            webDriver.FindElement(sour).Click();
            webDriver.FindElement(spoon).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(deep).Click();
            webDriver.FindElement(fruit).Click();
            webDriver.FindElement(cocktail).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Soy Salmon";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }
        [TestMethod]
        public void GetCuliflowerDipper6()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(winter).Click();
            webDriver.FindElement(coffee).Click();
            webDriver.FindElement(black).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(sweet).Click();
            webDriver.FindElement(sour).Click();
            webDriver.FindElement(spoon).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(deep).Click();
            webDriver.FindElement(fruit).Click();
            webDriver.FindElement(cocktail).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Culiflower Dipper";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }
        [TestMethod]
        public void GetCuliflowerDipper7()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(winter).Click();
            webDriver.FindElement(coffee).Click();
            webDriver.FindElement(white).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(sweet).Click();
            webDriver.FindElement(sour).Click();
            webDriver.FindElement(spoon).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(deep).Click();
            webDriver.FindElement(fruit).Click();
            webDriver.FindElement(cocktail).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Culiflower Dipper";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }
        [TestMethod]
        public void GetBlonde8()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(winter).Click();
            webDriver.FindElement(tea).Click();
            webDriver.FindElement(white).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(sweet).Click();
            webDriver.FindElement(sour).Click();
            webDriver.FindElement(spoon).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(deep).Click();
            webDriver.FindElement(fruit).Click();
            webDriver.FindElement(cocktail).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Blonde";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));

            webDriver.Close();
        }
        [TestMethod]
        public void GetBlonde9()
        {

            By problem3Menu = By.CssSelector("#ftco-nav > ul > li:nth-child(3) > a");
            By summer = By.Id("btn1");
            By winter = By.Id("btn2");
            By tea = By.Id("btn3");
            By coffee = By.Id("btn4");
            By white = By.Id("btn5");
            By black = By.Id("btn6");
            By sweet = By.Id("btn7");
            By salty = By.Id("btn8");
            By sour = By.Id("btn9");
            By hot = By.Id("btn10");
            By spoon = By.Id("btn11");
            By fork = By.Id("btn12");
            By deep = By.Id("btn13");
            By shallow = By.Id("btn14");
            By fruit = By.Id("btn15");
            By vegetables = By.Id("btn16");
            By cocktail = By.Id("btn17");
            By beer = By.Id("btn18");
            By readMyMind = By.Id("readmymind");
            By recommendation = By.Id("recHeader");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://10.15.1.204:3000/");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver;

            webDriver.FindElement(problem3Menu).Click();
            webDriver.FindElement(summer).Click();
            webDriver.FindElement(tea).Click();
            webDriver.FindElement(white).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(sweet).Click();
            webDriver.FindElement(sour).Click();
            webDriver.FindElement(spoon).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(deep).Click();
            webDriver.FindElement(fruit).Click();
            webDriver.FindElement(cocktail).Click();
            jse.ExecuteScript("window.scrollBy(0, 250);");
            webDriver.FindElement(readMyMind).Click();

            string expectedResult = "Blonde";
            var actualResult = webDriver.FindElement(recommendation);
            Assert.IsTrue(actualResult.Text.Equals(expectedResult));
        }
    }
}
