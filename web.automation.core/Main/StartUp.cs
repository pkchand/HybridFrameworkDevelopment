using mobile.automation.core.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile.automation.core.Main
{
    public class StartUp
    {
        public string GetEnv()
        {
            Console.WriteLine($"{DateTime.Now}--> GetTargetEnviromentName()");
            var TargetEnvironmentName = (TestContext.Parameters["TargetEnvironment"]??"prod").ToString();
            return TargetEnvironmentName;
        }

        public string GetExecution()
        {
            Console.WriteLine($"{DateTime.Now}--> GetTargetEnviromentName()");
            var TargetEnvironmentName = (TestContext.Parameters["ExecInLocal"] ?? "false").ToString();
            return TargetEnvironmentName;
        }

        public string GetTfsUsage()
        {
            Console.WriteLine($"{DateTime.Now}--> GetTargetEnviromentName()");
            var TargetEnvironmentName = (TestContext.Parameters["UseTfs"] ?? "false").ToString();
            return TargetEnvironmentName;
        }

        public static List<PickupModel> GetPickUpData(string country)
        {
            string RunSettingFile = TestContext.CurrentContext.WorkDirectory + "\\TestRunSetting\\Data\\PickUp.json";
            var jsonData = JsonConvert.DeserializeObject<List<PickupModel>>(File.ReadAllText(RunSettingFile));
            var requireData= jsonData.Where(q => q.Country == country).ToList();
            return requireData;
        }

        public static List<ShippingModel> GetShippingData(string country)
        {
            string RunSettingFile = TestContext.CurrentContext.WorkDirectory + "\\TestRunSetting\\Data\\Shipping.json";
            var jsonData = JsonConvert.DeserializeObject<List<ShippingModel>>(File.ReadAllText(RunSettingFile));
            var requireData = jsonData.Where(q => q.Country == country).ToList();
            return requireData;
        }

        public List<CardDetails> FillCardDetails(string country, string ccType)
        {
            string RunSettingFile = TestContext.CurrentContext.WorkDirectory + "\\TestRunSetting\\Data\\CreditCardDetails.json";
            var jsonData = JsonConvert.DeserializeObject<List<CardDetails>>(File.ReadAllText(RunSettingFile));
            var requireData = jsonData.Where(q => q.CountryCode == country & q.CCType==ccType).ToList();
            return requireData;
        }


    }
}
