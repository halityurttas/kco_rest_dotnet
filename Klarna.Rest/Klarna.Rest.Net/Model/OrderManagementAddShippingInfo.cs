﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Klarna.Rest.Net.Model
{
    public class OrderManagementAddShippingInfo
    {
        /// <summary>
        /// New shipping info. Maximum: 500 items.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_info")]
        public ICollection<OrderManagementShippingInfo> ShippingInfo { get; set; }
    }
}