// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="MonitorPrivateLinkScopedResource"/> and their operations.
    /// Each <see cref="MonitorPrivateLinkScopedResource"/> in the collection will belong to the same instance of <see cref="MonitorPrivateLinkScopeResource"/>.
    /// To get a <see cref="MonitorPrivateLinkScopedResourceCollection"/> instance call the GetMonitorPrivateLinkScopedResources method from an instance of <see cref="MonitorPrivateLinkScopeResource"/>.
    /// </summary>
    public partial class MonitorPrivateLinkScopedResourceCollection : ArmCollection, IEnumerable<MonitorPrivateLinkScopedResource>, IAsyncEnumerable<MonitorPrivateLinkScopedResource>
    {
        private readonly ClientDiagnostics _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics;
        private readonly PrivateLinkScopedResourcesRestOperations _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MonitorPrivateLinkScopedResourceCollection"/> class for mocking. </summary>
        protected MonitorPrivateLinkScopedResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MonitorPrivateLinkScopedResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MonitorPrivateLinkScopedResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", MonitorPrivateLinkScopedResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MonitorPrivateLinkScopedResource.ResourceType, out string monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesApiVersion);
            _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient = new PrivateLinkScopedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MonitorPrivateLinkScopeResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MonitorPrivateLinkScopeResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Approve or reject a private endpoint connection with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="data"> The MonitorPrivateLinkScopedResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MonitorPrivateLinkScopedResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, MonitorPrivateLinkScopedResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<MonitorPrivateLinkScopedResource>(new MonitorPrivateLinkScopedResourceOperationSource(Client), _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics, Pipeline, _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Approve or reject a private endpoint connection with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="data"> The MonitorPrivateLinkScopedResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MonitorPrivateLinkScopedResource> CreateOrUpdate(WaitUntil waitUntil, string name, MonitorPrivateLinkScopedResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new MonitorArmOperation<MonitorPrivateLinkScopedResource>(new MonitorPrivateLinkScopedResourceOperationSource(Client), _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics, Pipeline, _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a scoped resource in a private link scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<MonitorPrivateLinkScopedResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitorPrivateLinkScopedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a scoped resource in a private link scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<MonitorPrivateLinkScopedResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitorPrivateLinkScopedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all private endpoint connections on a private link scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_ListByPrivateLinkScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MonitorPrivateLinkScopedResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MonitorPrivateLinkScopedResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateListByPrivateLinkScopeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateListByPrivateLinkScopeNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MonitorPrivateLinkScopedResource(Client, MonitorPrivateLinkScopedResourceData.DeserializeMonitorPrivateLinkScopedResourceData(e)), _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics, Pipeline, "MonitorPrivateLinkScopedResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all private endpoint connections on a private link scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_ListByPrivateLinkScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MonitorPrivateLinkScopedResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MonitorPrivateLinkScopedResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateListByPrivateLinkScopeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateListByPrivateLinkScopeNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MonitorPrivateLinkScopedResource(Client, MonitorPrivateLinkScopedResourceData.DeserializeMonitorPrivateLinkScopedResourceData(e)), _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics, Pipeline, "MonitorPrivateLinkScopedResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<MonitorPrivateLinkScopedResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MonitorPrivateLinkScopedResource>(response.GetRawResponse());
                return Response.FromValue(new MonitorPrivateLinkScopedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<MonitorPrivateLinkScopedResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MonitorPrivateLinkScopedResource>(response.GetRawResponse());
                return Response.FromValue(new MonitorPrivateLinkScopedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MonitorPrivateLinkScopedResource> IEnumerable<MonitorPrivateLinkScopedResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MonitorPrivateLinkScopedResource> IAsyncEnumerable<MonitorPrivateLinkScopedResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
