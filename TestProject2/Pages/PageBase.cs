using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    public abstract class PageBase
    {
        protected IWebDriver driver { get; set; }
        public PageBase(IWebDriver driver)
        {
            this.driver = driver;
        }
        protected abstract string Url { get; }
        [AllureStep("Открытие страницы")]
        public void Open()
        {
            driver.Url = Url;
        }
    }
}
