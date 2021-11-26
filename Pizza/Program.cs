using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;
            driver = new ChromeDriver(@"C:\dovercorp");

            string url = "http://localhost:40871/";
            driver.Navigate().GoToUrl(url);
            


        }
    }
}
