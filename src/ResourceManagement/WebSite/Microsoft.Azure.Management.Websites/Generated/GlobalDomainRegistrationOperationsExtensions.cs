// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class GlobalDomainRegistrationOperationsExtensions
    {
            /// <summary>
            /// Lists all domains in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DomainCollection GetAllDomains(this IGlobalDomainRegistrationOperations operations)
            {
                return Task.Factory.StartNew(s => ((IGlobalDomainRegistrationOperations)s).GetAllDomainsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all domains in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainCollection> GetAllDomainsAsync( this IGlobalDomainRegistrationOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllDomainsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates a single sign on request for domain management portal
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DomainControlCenterSsoRequest GetDomainControlCenterSsoRequest(this IGlobalDomainRegistrationOperations operations)
            {
                return Task.Factory.StartNew(s => ((IGlobalDomainRegistrationOperations)s).GetDomainControlCenterSsoRequestAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates a single sign on request for domain management portal
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainControlCenterSsoRequest> GetDomainControlCenterSsoRequestAsync( this IGlobalDomainRegistrationOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDomainControlCenterSsoRequestWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Validates domain registration information
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='domainRegistrationInput'>
            /// Domain registration information
            /// </param>
            public static object ValidateDomainPurchaseInformation(this IGlobalDomainRegistrationOperations operations, DomainRegistrationInput domainRegistrationInput)
            {
                return Task.Factory.StartNew(s => ((IGlobalDomainRegistrationOperations)s).ValidateDomainPurchaseInformationAsync(domainRegistrationInput), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validates domain registration information
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='domainRegistrationInput'>
            /// Domain registration information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ValidateDomainPurchaseInformationAsync( this IGlobalDomainRegistrationOperations operations, DomainRegistrationInput domainRegistrationInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateDomainPurchaseInformationWithHttpMessagesAsync(domainRegistrationInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks if a domain is available for registration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='identifier'>
            /// Name of the domain
            /// </param>
            public static DomainAvailablilityCheckResult CheckDomainAvailability(this IGlobalDomainRegistrationOperations operations, NameIdentifier identifier)
            {
                return Task.Factory.StartNew(s => ((IGlobalDomainRegistrationOperations)s).CheckDomainAvailabilityAsync(identifier), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks if a domain is available for registration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='identifier'>
            /// Name of the domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainAvailablilityCheckResult> CheckDomainAvailabilityAsync( this IGlobalDomainRegistrationOperations operations, NameIdentifier identifier, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckDomainAvailabilityWithHttpMessagesAsync(identifier, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists domain recommendations based on keywords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Domain recommendation search parameters
            /// </param>
            public static NameIdentifierCollection ListDomainRecommendations(this IGlobalDomainRegistrationOperations operations, DomainRecommendationSearchParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IGlobalDomainRegistrationOperations)s).ListDomainRecommendationsAsync(parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists domain recommendations based on keywords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Domain recommendation search parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NameIdentifierCollection> ListDomainRecommendationsAsync( this IGlobalDomainRegistrationOperations operations, DomainRecommendationSearchParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDomainRecommendationsWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
