using AddressSearchAPITests.Helpers;
using AddressSearchAPITests.Services;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressSearchAPITests.Core
{
    public class BaseTest
    {
        protected AddressSearchServices addressSearchServices;
        protected ExtentTest _test;

        [SetUp]
        public void Setup()
        {
            addressSearchServices = new AddressSearchServices();
        }
    }
}
