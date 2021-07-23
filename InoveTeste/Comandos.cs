using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InoveTeste
{
    class Comandos
    {
 

        public static IWebDriver GetBrowserLocal (IWebDriver driver, String browser)
        {
            switch (browser)
            {
                case "Fire Fox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;

                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;
            }
            return driver;
        }
    }
}