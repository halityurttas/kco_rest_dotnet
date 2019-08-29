﻿using Newtonsoft.Json;

namespace Klarna.Rest.Net.Model
{
    /// <summary>
    /// Create hosted payment page session request
    /// </summary>
    public class HostedPaymentPageCreateSessionRequest
    {
        /// <summary>
        /// Urls used to redirect the consumer
        /// </summary>
        [JsonProperty(PropertyName = "merchant_urls")]
        public HostedPaymentPageMerchantUrls MerchantUrls { get; set; }
        /// <summary>
        /// Options
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public HostedPaymentPageOptions Options { get; set; }
        /// <summary>
        /// Url for the KP session
        /// </summary>
        [JsonProperty(PropertyName = "payment_session_url")]
        public string PaymentSessionUrl { get; set; }
    }
}
