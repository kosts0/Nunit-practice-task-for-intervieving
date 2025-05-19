using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Utilities
{
    public static class WebElementEx
    {
        public static IWebElement FindElementOrNull(this IWebElement element, By locator)
        {
            return element.FindElements(locator).FirstOrDefault();
        }
    }
}
