using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressSearchAPITests.Models
{
    public class SearchResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("features")]
       public List<Features> Features { get; set; }
        [JsonProperty("query")]
        public string Query { get; set; }

    }
}
