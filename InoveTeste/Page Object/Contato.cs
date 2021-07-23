using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoveTeste.Page_Object
{
    class Contato
    {
        [FindsBy(How = How.Name, Using = "your-name")]
        public IWebElement name { get; set; }

        [FindsBy(How = How.Name, Using = "your-email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "your-subject")]
        public IWebElement subject { get; set; }

        [FindsBy(How = How.Name, Using = "your-message")]
        public IWebElement message { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.wpcf7-form-control.wpcf7-submit")]
        public IWebElement buttonEnviar { get; set; }

        /*[FindsBy(How = How.XPath, Using = "//div[@id='wpcf7-f372-p24-o1']/form/div[2]")]
        public IWebElement messageSuccess { get; set; }*/

    }
}
