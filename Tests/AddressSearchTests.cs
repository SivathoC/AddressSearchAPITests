using AddressSearchAPITests.Core;
using FluentAssertions;

namespace AddressSearchAPITests.Tests
{
    [TestFixture]
    public class AddressSearchTests : BaseTest
    {
        [TestCase("8 Boulevard du Port 95000 Cergy")]
        public async Task SearchAdress_ShouldReturnValidResponse(string query)
        {
            var response = await addressSearchServices.SearchAddress(query);
            response.Should().NotBeNull();
            foreach(var feature in response.Features)
            {
                feature.Properties.Label.Should().Be(query);
            }
        }

    }
}
