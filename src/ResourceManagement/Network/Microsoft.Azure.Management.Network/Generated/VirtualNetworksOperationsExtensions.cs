// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class VirtualNetworksOperationsExtensions
    {
            /// <summary>
            /// The Delete VirtualNetwork operation deletes the specifed virtual network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static void Delete(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).DeleteAsync(resourceGroupName, virtualNetworkName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete VirtualNetwork operation deletes the specifed virtual network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Delete VirtualNetwork operation deletes the specifed virtual network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static void BeginDelete(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).BeginDeleteAsync(resourceGroupName, virtualNetworkName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete VirtualNetwork operation deletes the specifed virtual network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync( this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get VirtualNetwork operation retrieves information about the specified
            /// virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            public static VirtualNetwork Get(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).GetAsync(resourceGroupName, virtualNetworkName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get VirtualNetwork operation retrieves information about the specified
            /// virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetwork> GetAsync( this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put VirtualNetwork operation creates/updates a virtual network in the
            /// specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Virtual Network operation
            /// </param>
            public static VirtualNetwork CreateOrUpdate(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters)
            {
                return Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).CreateOrUpdateAsync(resourceGroupName, virtualNetworkName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put VirtualNetwork operation creates/updates a virtual network in the
            /// specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Virtual Network operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetwork> CreateOrUpdateAsync( this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put VirtualNetwork operation creates/updates a virtual network in the
            /// specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Virtual Network operation
            /// </param>
            public static VirtualNetwork BeginCreateOrUpdate(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters)
            {
                return Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put VirtualNetwork operation creates/updates a virtual network in the
            /// specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Virtual Network operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetwork> BeginCreateOrUpdateAsync( this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VirtualNetwork> ListAll(this IVirtualNetworksOperations operations)
            {
                return Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetwork>> ListAllAsync( this IVirtualNetworksOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<VirtualNetwork> List(this IVirtualNetworksOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetwork>> ListAsync( this IVirtualNetworksOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetwork> ListAllNext(this IVirtualNetworksOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetwork>> ListAllNextAsync( this IVirtualNetworksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetwork> ListNext(this IVirtualNetworksOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetwork>> ListNextAsync( this IVirtualNetworksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
