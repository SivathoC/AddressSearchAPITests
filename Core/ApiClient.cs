using RestSharp;

namespace AddressSearchAPITests.Core
{
    public class ApiClient
    {
        private readonly RestClient _client;

        public ApiClient()
        {
            _client = new RestClient(ConfigurationManager.BaseUrl);
        }

        public async Task <RestResponse> GetAsync(string endpoint, Dictionary<string,string>? parameters)
        {
            var request = new RestRequest(endpoint, Method.Get);
            if(parameters != null)
            {
                foreach (var param in parameters)
                {
                    request.AddParameter(param.Key, param.Value);
                }
            }
            return await _client.ExecuteAsync(request);
        }
    }
}
