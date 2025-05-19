using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    public abstract class BlockBase(IWebElement rootElement)
    {
        protected IWebElement rootElement { get; set; }
    }
}
