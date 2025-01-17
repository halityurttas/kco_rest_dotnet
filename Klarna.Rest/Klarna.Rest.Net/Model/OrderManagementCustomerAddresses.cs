﻿using Newtonsoft.Json;

namespace Klarna.Rest.Net.Model
{
    public class OrderManagementCustomerAddresses
    {
        /// <summary>
        /// Customer shipping address.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_address")]
        public OrderManagementAddressInfo ShippingAddress { get; set; }
        /// <summary>
        /// Customer billing address.
        /// </summary>
        [JsonProperty(PropertyName = "billing_address")]
        public OrderManagementAddressInfo BillingAddress { get; set; }
    }
}