using AddressSearchAPITests.Core;
using AddressSearchAPITests.Models;
using FluentAssertions;
using Newtonsoft.Json;

namespace AddressSearchAPITests.Services
{
    public class AddressSearchServices
    {
        private readonly ApiClient _client;

        public AddressSearchServices()
        {
            this._client = new ApiClient();
        }
        public async Task<SearchResponse> SearchAddress(string query) {
            var parameters = new Dictionary<string, string>
            {
                { "q", query }
            };
            var response = await _client.GetAsync("/search", parameters);
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            var searchResponse = JsonConvert.DeserializeObject<SearchResponse>(response.Content);
            return searchResponse;
        }
    }
}
