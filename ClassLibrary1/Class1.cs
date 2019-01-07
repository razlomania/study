using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace ClassLibrary1
{
    class NUnitTest
    {

        // Email user@phptravels.com
        //  Password demouser

        private IWebDriver driver;

        [SetUp]
        public void Initizalize()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application\\");
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.demoqa.com";
            driver.Navigate();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
