﻿using Newtonsoft.Json;

namespace Klarna.Rest.Net.Model
{
    /// <summary>
    /// Hosted payment page contact information
    /// </summary>
    public class HostedPaymentPageContactInformation
    {
        /// <summary>
        /// Email where to send the email with the HPP link. Only required if distribution method is 'email'
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        /// <summary>
        /// Phone number where to send the sms with the HPP link. Only required if distribution method is 'sms'
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        /// <summary>
        /// ISO 3166 alpha-2 phone country. Only required if distribution method is 'sms'
        /// </summary>
        [JsonProperty(PropertyName = "phone_country")]
        public string PhoneCountry { get; set; }
    }
}