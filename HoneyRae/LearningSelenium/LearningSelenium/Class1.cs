using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSelenium
{
    internal class theTechAcademyTest
    {
        [Test]
        public void SimpleTest()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1200);
            driver.Navigate().GoToUrl("https://localhost:3000");
            driver.FindElement(OpenQA.Selenium.By.ClassName("find-tutor-btn.btn-primary")).Click();
        }
    };
}
