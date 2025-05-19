using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Utilities;

namespace TestProject2.Pages
{
    public class CardBlock : BlockBase
    {
        public CardBlock(IWebElement rootElement) : base(rootElement)
        {
        }

        public IWebElement Title => rootElement.FindElementOrNull(By.CssSelector(".card-title"));
        public IWebElement Price => rootElement.FindElementOrNull(By.TagName("h4"));
    }
}
