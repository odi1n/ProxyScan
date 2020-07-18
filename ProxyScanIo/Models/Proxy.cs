using Newtonsoft.Json;
using ProxyScanIo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyScanIo.Models
{
    public class Proxy
    {
        [JsonProperty("Ip")]
        public string Ip { get; set; }

        [JsonProperty("Port")]
        public long Port { get; set; }

        [JsonProperty("Ping")]
        public long Ping { get; set; }

        [JsonProperty("Time")]
        public long Time { get; set; }

        [JsonProperty("Location")]
        public Location Location { get; set; }

        [JsonProperty("Type")]
        public List<TypeProxy> Type { get; set; }

        [JsonProperty("Failed")]
        public bool Failed { get; set; }

        [JsonProperty("Anonymity")]
        public Anonymity Anonymity { get; set; }

        [JsonProperty("WorkingCount")]
        public long WorkingCount { get; set; }

        [JsonProperty("Uptime")]
        public double Uptime { get; set; }

        [JsonProperty("RecheckCount")]
        public long RecheckCount { get; set; }

        public override string ToString()
        {
            return Ip+":"+Port;
        }
    }
}
