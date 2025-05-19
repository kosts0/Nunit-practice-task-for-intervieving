using Allure.Net.Commons;
using Allure.NUnit;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.IO;
using TestProject2.ApiManager;
using TestProject2.Pages;

namespace TestProject
{
    [TestFixture(typeof(ChromeDriver))]
    [Parallelizable(ParallelScope.All)]
    [AllureNUnit]
    public class FixturedTest
    {
        private Type browserType { get; set; }
        public FixturedTest(Type driverType)
        {
            browserType = driverType;
        }
        ThreadLocal<IWebDriver> _driver = new ThreadLocal<IWebDriver>();
        private static IEnumerable<int> testThread => new List<int>() { 1 };
        [SetUp]
        public void Setup()
        {
            _driver = new ThreadLocal<IWebDriver>(() => Activator.CreateInstance(browserType) as IWebDriver);
        }
        [Test]
        [TestCaseSource(nameof(testThread))]
        public void Test(int thread)
        {
            var page = new ProductsPage(_driver.Value);
            var api = new CatalogApi();
            var items = api.ItemList();
            page.Open();
            AllureApi.Step("Валидация", () =>
            {
                AllureApi.Step("todo");
            });
        }
        [TearDown]
        public void TearDown()
        {
            _driver.Value.Quit();
        }


    }
}