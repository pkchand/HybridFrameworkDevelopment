using mobile.automation.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile.automation.core
{
    public class TestRunnerModel
    {
        public Urls urls { get; set; }
        public TestData testData { get; set; }
        public DeviceHelper deviceType  { get; set; }
        public string locale { get; set; }
        public string countryCode { get; set; }
        public string Token { get; set; }
        public string targetEnvironment { get; set; }
        public string useTFS { get; set; }
        public string localExecution { get; set; }
    }
}
