﻿using Newtonsoft.Json;

namespace Klarna.Rest.Net.Model
{
    public class PaymentMethodCategoryAssetUrls
    {
        /// <summary>
        /// Descriptive asset URL
        /// </summary>
        [JsonProperty(PropertyName = "descriptive")]
        public string Descriptive { get; set; }
        /// <summary>
        /// Standard asset URL
        /// </summary>
        [JsonProperty(PropertyName = "standard")]
        public string Standard { get; set; }
    }
}