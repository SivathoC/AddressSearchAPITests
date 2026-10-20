using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressSearchAPITests.Core
{
    [SetUpFixture]
    public class TestBase
    {
        public static ExtentReports Extent;

        [OneTimeSetUp]
        public void ReportSetup()
        {
            string reportPath = Path.Combine(
                TestContext.CurrentContext.WorkDirectory,
                "Reports",
                "index.html");

            Directory.CreateDirectory(
                Path.GetDirectoryName(reportPath)!);

            var sparkReporter = new ExtentSparkReporter(reportPath);

            Extent = new ExtentReports();
            Extent.AttachReporter(sparkReporter);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Extent.Flush();
        }
    }
}
