using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    public class ProductsPage : PageBase
    {
        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }
        protected override string Url => "https://www.demoblaze.com/";
        public CardBlock[] CardList => driver.FindElements(By.CssSelector(".card")).Select(e => new CardBlock(e)).ToArray();
    }
}
