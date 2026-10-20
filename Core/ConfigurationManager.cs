using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressSearchAPITests.Core
{
    public class ConfigurationManager
    {
        private static IConfigurationRoot configuration;
        static ConfigurationManager()
        {
            configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        }
        public static string BaseUrl => configuration["ApiSettings:BaseUrl"];
    }
}
