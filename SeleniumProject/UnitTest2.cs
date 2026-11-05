
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject
{
    public class UnitTest2
    {
        //Testing branches
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.example.com");
            // Add your test logic here
            driver.Quit();
        }
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.example.com");
            // Add your test logic here
            driver.Quit();
        }
    }
}
