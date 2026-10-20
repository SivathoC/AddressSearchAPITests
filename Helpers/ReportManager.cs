using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressSearchAPITests.Helpers
{
    public static class ReportManager
    {
        private static ExtentReports _extent;
        public static ExtentReports Extent
        {
            get
            {
                if (_extent == null)
                {
                    string reportPath = Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        "Reports", "ExtentReport.html");

                    Directory.CreateDirectory(
                        Path.GetDirectoryName(reportPath)!);

                    var spark = new ExtentSparkReporter(reportPath);
                    _extent = new ExtentReports();
                    _extent.AttachReporter(spark);
                }
                return _extent;
            }

        }
    }
}
