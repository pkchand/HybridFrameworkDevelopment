using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using mobile.automation.core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.automation.core
{
    public class BaseTest
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set; }
        public dynamic localization;
        ExtentTest ParentTest;
        public ExtentTest ChildTest { get; set; }
        public string Token;
        public Dictionary<int, TestStatus> TestStatusContainer = new Dictionary<int, TestStatus>();
        public RestClient _rest;
        public TestRunnerModel testModel;
        private string Locale = "en-US";
        private static int count = 0;

        public BaseTest(string locale, DeviceHelper deviceHelper)
        {
            Reporter.ReporterInstance.CreateReporter();
            count++;
            Locale = locale;
            Init(locale, deviceHelper);
        }

        public void Init(string locale, DeviceHelper deviceHelper)
        {

        }

        internal void SetDriver()
        {
            Uri uri;
            AppiumOptions appiumOptions = new AppiumOptions();
            var testName = TestContext.CurrentContext.Test.Name + "_" + Locale;
            new LocalCapabilities().SetLocalCapabilities(appiumOptions, testModel);
            uri = new Uri("http://127.0.01:4723/wd/hub");
            if (testModel.deviceType == DeviceHelper.Ios || testModel.deviceType == DeviceHelper.Ipad)
            {
                Driver = new IOSDriver<AppiumWebElement>(uri, appiumOptions, TimeSpan.FromMinutes(10));
            }
            else
            {
                Driver = new AndroidDriver<AppiumWebElement>(uri, appiumOptions, TimeSpan.FromMinutes(10));
            }
        }

        public static string GetReportDataPath()
        {
            var path = TestContext.CurrentContext.WorkDirectory;
            string fullPath;
            if (path.Contains("Agent"))
            {
                fullPath = path;
            }
            else
            {
                fullPath = path.Substring(0, path.LastIndexOf("bin"));
            }
            return fullPath + "\\ReportData.json";
        }


    }
}
