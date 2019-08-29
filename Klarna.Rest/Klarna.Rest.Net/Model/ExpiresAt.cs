using Newtonsoft.Json;

namespace Klarna.Rest.Net.Model
{
    public class ExpiresAt
    {
        [JsonProperty(PropertyName = "nano")]
        public int Nano { get; set; }
        [JsonProperty(PropertyName = "epoch_second")]
        public int EpochSecond { get; set; }
    }
}