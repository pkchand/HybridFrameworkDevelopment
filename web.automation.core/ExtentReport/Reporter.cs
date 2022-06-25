using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile.automation.core
{
    public class Reporter
    {
        public static readonly Lazy<Reporter> lazyReporter = new Lazy<Reporter>(() => new Reporter());
        public AventStack.ExtentReports.ExtentReports extentReporter;
        public string ReportPath { get; }
        private Reporter()
        {

        }
        public static Reporter ReporterInstance { get { return lazyReporter.Value; } }
        public void CreateReporter()
        {

        }
    }
}
