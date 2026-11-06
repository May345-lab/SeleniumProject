
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver=new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://www.uitestingplayground.com/");
            driver.Manage().Window.Maximize();

            IWebElement dynamicId = driver.FindElement(By.XPath("//a[@href='/dynamicid']"));
            dynamicId.Click();

            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
            //testing git push
            //testing git pull
            //testing git fetch
        }
    }
}
