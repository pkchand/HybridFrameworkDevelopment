using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile.automation.core
{
    class LocalCapabilities
    {
        public void SetLocalCapabilities(AppiumOptions appiumOptions, TestRunnerModel testModel)
        {
            if (testModel.deviceType == DeviceHelper.Android)
            {
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9.0");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, "");
                appiumOptions.AddAdditionalCapability("autoGrantPermissions", "true");
                appiumOptions.AddAdditionalCapability("appPackage", "packageName");
                appiumOptions.AddAdditionalCapability("appActivity", "MainActivity");
            }
            else if (testModel.deviceType == DeviceHelper.Tablet)
            {
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11.0");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, "");
                appiumOptions.AddAdditionalCapability("autoGrantPermissions", "true");
                appiumOptions.AddAdditionalCapability("appPackage", "packageName");
                appiumOptions.AddAdditionalCapability("appActivity", "MainActivity");
            }
            else if (testModel.deviceType == DeviceHelper.Ios)
            {
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "IOS");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "13.5");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 11");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, "");
                appiumOptions.AddAdditionalCapability("autoGrantPermissions", "true");
                appiumOptions.AddAdditionalCapability("autoAcceptAlerts", "true");
                appiumOptions.AddAdditionalCapability("autoDismissAlert", "true");
            }
            else if (testModel.deviceType == DeviceHelper.Ipad)
            {
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "IOS");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "13.5");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 11");
                appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, "");
                appiumOptions.AddAdditionalCapability("autoGrantPermissions", "true");
                appiumOptions.AddAdditionalCapability("autoAcceptAlerts", "true");
                appiumOptions.AddAdditionalCapability("autoDismissAlert", "true
            }

        }
    }
}
