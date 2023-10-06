using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitUIAutomationUpgrade.Pages
{
    public class PatientsPage
    {
        [FindsBy(How = How.XPath, Using = "//neu-tab[@id='Reusable-Tab-Issues']")]
        private IWebElement IssueTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//neu-tab[@id='Reusable-Tab-Feedback']")]
        private IWebElement FeedbackTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//neu-tab[@id='Reusable-Tab-Stoplight']")]
        private IWebElement StoplightTab { get; set; }

        [FindsBy(How = How.Id, Using = "Login-Button")]

        [FindsBy(How = How.XPath, Using = "//neu-button[@id='Download-Button']")]
        private IWebElement DownloadTab { get; set; }


        private IWebElement LoginButton{ get; set; }

        public IWebDriver driver;


        public PatientsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            this.driver = driver;
        }

        public void AddIssue()
        {
            IssueTab.Click();
            DownloadTab.Click();
        }

        public void AddFeedback()

        {
            FeedbackTab.Click();
        }

        public void AddStoplight() 
        {
            StoplightTab.Click();
        }

        public void DownloadFile() 
        {
            DownloadTab.Click();
        }
    }
}
