using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.baidu.com");
            driver.FindElement(By.Id("kw")).SendKeys("Selenium");
            driver.FindElement(By.Id("su")).Click();

            driver.Quit();

        }
    }
}
