using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using mobile.automation.core;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
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
            
        }


    }
}
