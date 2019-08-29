﻿using System.Threading.Tasks;
using Klarna.Rest.Net.Common;
using Klarna.Rest.Net.Commuication;
using Klarna.Rest.Net.Commuication.Dto;
using Klarna.Rest.Net.Model;
using Klarna.Rest.Net.Serialization;

namespace Klarna.Rest.Net.Store
{
    /// <summary>
    /// Customer Token API
    /// The Customer Token API is used to charge customers with a tokenized Klarna payment method and can be used for recurring purchases, subscriptions and for storing a customer's payment method. Tokens are created using the generate a customer token call in the payments API.
    /// </summary>
    public class CustomerTokenStore : BaseStore
    {
        internal CustomerTokenStore(ApiSession apiSession, IJsonSerializer jsonSerializer) : base(apiSession, ApiControllers.CustomerToken, jsonSerializer) { }

        /// <summary>
        /// Read customer tokens details
        /// </summary>
        /// <param name="customerToken">Customer token</param>
        /// <returns><see cref="CustomerTokenDetails"/></returns>
        public async Task<CustomerTokenDetails> GetCustomerTokenDetails(string customerToken)
        {
            var url = ApiUrlHelper.GetApiUrlForController(ApiSession.ApiUrl, ApiControllerUri, customerToken);

            return await Get<CustomerTokenDetails>(url).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a new order using the customer token
        /// </summary>
        /// <param name="customerToken">Customer token</param>
        /// <param name="order">A <see cref="CustomerTokenOrder"/> object</param>
        /// <returns><see cref="CustomerTokenCreateOrderResponse"/></returns>
        public async Task<CustomerTokenCreateOrderResponse> CreateOrder(string customerToken, CustomerTokenOrder order)
        {
            var url = ApiUrlHelper.GetApiUrlForController(ApiSession.ApiUrl, ApiControllerUri, $"{customerToken}/order");
            return await Post<CustomerTokenCreateOrderResponse>(url, order).ConfigureAwait(false);
        }

        /// <summary>
        /// Update the status of a customer token
        /// </summary>
        /// <param name="customerToken">Customer token</param>
        /// <param name="update">A <see cref="CustomerTokenStatusUpdateRequest"/> object</param>
        /// <returns><see cref="CustomerTokenCreateOrderResponse"/></returns>
        public Task UpdateStatus(string customerToken, CustomerTokenStatusUpdateRequest update)
        {
            var url = ApiUrlHelper.GetApiUrlForController(ApiSession.ApiUrl, ApiControllerUri, $"{customerToken}/status");
            return Patch(url, update);
        }
    }
}
