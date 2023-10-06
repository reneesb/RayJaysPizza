
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System.Configuration;
using System.Reflection;
using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Linq;

namespace OrbitUIAutomationUpgrade.Base_Utilities
{
    public class BaseTest
    {
        public static string ScreenShotFilePath;
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(BaseTest));
        public static string URL;
        public static string Todaysdate = DateTime.Now.ToString("MM-dd-yyyy");

        public IWebDriver BrowserInvoke()
        {
            getProperties();
            if (!Directory.Exists(ScreenShotFilePath))
            {
                Directory.CreateDirectory(ScreenShotFilePath);
            }

            //ChromeOptions options = new ChromeOptions();
            //options.SetLoggingPreference(LogType.Browser, LogLevel.All);
            //options.AddArguments("");
            //Console.WriteLine(options);
            //logger.Info("chromeoptions logs: " + options);

            var baseDriver = new ChromeDriver();

            //ICapabilities capabilities = ((RemoteWebDriver)baseDriver).Capabilities;
            //logger.Info("Browser succesfully Invoked and browser version: " + capabilities.GetCapability("browserVersion"));
            baseDriver.Manage().Window.Maximize();
            return baseDriver;
        }
        public void GoToRootUrlAndLogin(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(URL);
            logger.Info("Navigated succesfully to Esaf QA: " + URL);
            driver.FindElement(By.XPath("//neu-input[@id='Login-Input-Box']/div/input")).SendKeys("zzr0533");
            driver.FindElement(By.Id("Login-Button")).Click();
        }
        private void getProperties()
        {
            ScreenShotFilePath = getProperty("screenShotFilePath") + Todaysdate;
            URL = getProperty("URL");
        }
        private string getProperty(string key)
        {
            return ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location).AppSettings.Settings[key].Value;
        }

    }
}
