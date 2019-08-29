﻿using System.Threading.Tasks;
using Klarna.Rest.Net.Common;
using Klarna.Rest.Net.Commuication;
using Klarna.Rest.Net.Commuication.Dto;
using Klarna.Rest.Net.Model;
using Klarna.Rest.Net.Serialization;

namespace Klarna.Rest.Net.Store
{
    /// <summary>
    /// Hosted Payment Page API
    /// Hosted Payment Page (HPP) API is a service that lets you integrate Klarna Payments without the need of hosting the web page that manages the client side of Klarna Payments.
    /// A complete HPP payment session will involve three of Klarna services:
    /// * Klarna Payments API to start a payment session.
    /// * Hosted Payment Page API to distribute a payment session.
    /// * Order Management API to capture payment or refund consumer.
    /// </summary>
    public class HostedPaymentPageStore : BaseStore
    {
        internal HostedPaymentPageStore(ApiSession apiSession, IJsonSerializer jsonSerializer) : base(apiSession, ApiControllers.HostedPaymentPage, jsonSerializer) { }

        /// <summary>
        /// Create a new HPP session
        /// </summary>
        /// <param name="session">The <see cref="HostedPaymentPageCreateSessionRequest"/> object</param>
        /// <returns>A single <see cref="HostedPaymentPageCreateSessionResponse"/> object</returns>
        public async Task<HostedPaymentPageCreateSessionResponse> CreateSession(
            HostedPaymentPageCreateSessionRequest session)
        {
            var url = ApiUrlHelper.GetApiUrlForController(ApiSession.ApiUrl, ApiControllerUri);
            return await Post<HostedPaymentPageCreateSessionResponse>(url, session).ConfigureAwait(false);
        }

        /// <summary>
        /// Distribute link to the HPP session
        /// </summary>
        /// <param name="sessionId">HPP session id</param>
        /// <param name="distribution">The <see cref="HostedPaymentPageDistributeLink"/> object</param>
        /// <returns></returns>
        public Task DistributeLinkToSession(string sessionId, HostedPaymentPageDistributeLink distribution)
        {
            var url = ApiUrlHelper.GetApiUrlForController(ApiSession.ApiUrl, ApiControllerUri, $"{sessionId}/distribution");
            return Post(url);
        }

        /// <summary>
        /// Get HPP session status
        /// </summary>
        /// <param name="sessionId">HPP session id</param>
        /// <returns>A single <see cref="HostedPaymentPageSessionStatus"/> object</returns>
        public async Task<HostedPaymentPageSessionStatus> GetSessionStatus(string sessionId)
        {
            var url = ApiUrlHelper.GetApiUrlForController(ApiSession.ApiUrl, ApiControllerUri, $"{sessionId}/status");
            return await Get<HostedPaymentPageSessionStatus>(url).ConfigureAwait(false);
        }
    }
}
