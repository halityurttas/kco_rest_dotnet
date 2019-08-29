using Newtonsoft.Json;
namespace Klarna.Rest.Net.Model
{
    public class CustomerDirectDebitTokenDetails
    {
        [JsonProperty(PropertyName = "brand")]
        public string Brand;
        [JsonProperty(PropertyName = "masked_number")]
        public string MaskedNumber;
    }
}
