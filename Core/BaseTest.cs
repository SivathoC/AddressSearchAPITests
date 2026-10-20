using AddressSearchAPITests.Services;
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

        [SetUp]
        public void Setup()
        {
            addressSearchServices = new AddressSearchServices();
        }
    }
}
