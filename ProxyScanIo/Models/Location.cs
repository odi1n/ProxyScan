using Newtonsoft.Json;
using ProxyScanIo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyScanIo.Models
{
    public partial class Location
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public Country CountryCode { get; set; }

        [JsonProperty("ipName")]
        public string IpName { get; set; }

        [JsonProperty("ipType")]
        public string IpType { get; set; }

        [JsonProperty("isp")]
        public string Isp { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("org")]
        public string Org { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
