using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressSearchAPITests.Models
{
    public class Properties
    {
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("score")]
        public double Score { get; set; }
        [JsonProperty("housenumber")]
        public string Housenumber { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("banId")]
        public string BanId { get; set; }
        [JsonProperty("postcode")]
        public string Postcode { get; set; }
        [JsonProperty("citycode")]
        public string CityCode { get; set; }       
        [JsonProperty("x")]
        public double X { get; set; }
        [JsonProperty("y")]
        public double Y { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("importance")]
        public float Importance { get; set; }
        [JsonProperty("street")]
        public string Street { get; set; }
        [JsonProperty("_type")]
        public string _Type { get; set; }

    }
}
