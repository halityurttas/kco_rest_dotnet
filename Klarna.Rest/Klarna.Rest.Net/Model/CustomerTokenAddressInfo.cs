﻿using Newtonsoft.Json;

namespace Klarna.Rest.Net.Model
{
    /// <summary>
    /// Customer token address info objects
    /// </summary>
    public class CustomerTokenAddressInfo
    {
        /// <summary>
        /// Attention
        /// </summary>
        [JsonProperty(PropertyName = "attention")]
        public string Attention { get; set; }
        /// <summary>
        /// City.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        /// <summary>
        /// ISO 3166 alpha-2. Country.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        /// <summary>
        /// E-mail address.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        /// <summary>
        /// Family name.
        /// </summary>
        [JsonProperty(PropertyName = "family_name")]
        public string FamilyName { get; set; }
        /// <summary>
        /// Given name.
        /// </summary>
        [JsonProperty(PropertyName = "given_name")]
        public string GivenName { get; set; }
        /// <summary>
        /// Organization name.
        /// </summary>
        [JsonProperty(PropertyName = "organization_name")]
        public string OrganizationName { get; set; }
        /// <summary>
        /// Phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        /// <summary>
        /// Postal/post code.
        /// </summary>
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }
        /// <summary>
        /// State or Region.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        /// <summary>
        /// Street address, first line.
        /// </summary>
        [JsonProperty(PropertyName = "street_address")]
        public string StreetAddress { get; set; }
        /// <summary>
        /// Street address, second line.
        /// </summary>
        [JsonProperty(PropertyName = "street_address2")]
        public string StreetAddress2 { get; set; }
        /// <summary>
        /// Title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}