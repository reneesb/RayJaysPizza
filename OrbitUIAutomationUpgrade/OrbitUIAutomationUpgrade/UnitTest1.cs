using NUnit.Framework;
using OrbitUIAutomationUpgrade.Base_Utilities;
using OrbitUIAutomationUpgrade.Pages;
using System.Drawing.Printing;

namespace OrbitUIAutomationUpgrade
{
    public class Tests:BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPatientIssue()
        {
           var driver = BrowserInvoke();
            GoToRootUrlAndLogin(driver);
            
            PatientsPage patientsPage = new PatientsPage(driver);
            patientsPage.AddIssue();
            patientsPage.DownloadFile();
        }


        [Test]
        public void AddPatientFeedback()
        {
            var driver = BrowserInvoke();
            GoToRootUrlAndLogin(driver);

            PatientsPage patientsPage = new PatientsPage(driver);
            patientsPage.AddFeedback();
        }

        [Test]
        public void AddPatienStoplight()
        {
            var driver = BrowserInvoke();
            GoToRootUrlAndLogin(driver);

            PatientsPage patientsPage = new PatientsPage(driver);
            patientsPage.AddStoplight();
        }

        [Test]
        public void DownloadIssuesList()
        {
            var driver = BrowserInvoke();
            GoToRootUrlAndLogin(driver);

            PatientsPage patientsPage = new PatientsPage(driver);
            patientsPage.DownloadFile();
        }




    }

}