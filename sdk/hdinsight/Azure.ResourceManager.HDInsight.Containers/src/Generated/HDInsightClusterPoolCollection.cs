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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HDInsight.Containers
{
    /// <summary>
    /// A class representing a collection of <see cref="HDInsightClusterPoolResource"/> and their operations.
    /// Each <see cref="HDInsightClusterPoolResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="HDInsightClusterPoolCollection"/> instance call the GetHDInsightClusterPools method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class HDInsightClusterPoolCollection : ArmCollection, IEnumerable<HDInsightClusterPoolResource>, IAsyncEnumerable<HDInsightClusterPoolResource>
    {
        private readonly ClientDiagnostics _hdInsightClusterPoolClusterPoolsClientDiagnostics;
        private readonly ClusterPoolsRestOperations _hdInsightClusterPoolClusterPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HDInsightClusterPoolCollection"/> class for mocking. </summary>
        protected HDInsightClusterPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HDInsightClusterPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HDInsightClusterPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hdInsightClusterPoolClusterPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HDInsight.Containers", HDInsightClusterPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HDInsightClusterPoolResource.ResourceType, out string hdInsightClusterPoolClusterPoolsApiVersion);
            _hdInsightClusterPoolClusterPoolsRestClient = new ClusterPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hdInsightClusterPoolClusterPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="data"> The Cluster Pool to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HDInsightClusterPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string clusterPoolName, HDInsightClusterPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterPoolName, nameof(clusterPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hdInsightClusterPoolClusterPoolsClientDiagnostics.CreateScope("HDInsightClusterPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hdInsightClusterPoolClusterPoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainersArmOperation<HDInsightClusterPoolResource>(new HDInsightClusterPoolOperationSource(Client), _hdInsightClusterPoolClusterPoolsClientDiagnostics, Pipeline, _hdInsightClusterPoolClusterPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="data"> The Cluster Pool to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HDInsightClusterPoolResource> CreateOrUpdate(WaitUntil waitUntil, string clusterPoolName, HDInsightClusterPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterPoolName, nameof(clusterPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hdInsightClusterPoolClusterPoolsClientDiagnostics.CreateScope("HDInsightClusterPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hdInsightClusterPoolClusterPoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, data, cancellationToken);
                var operation = new ContainersArmOperation<HDInsightClusterPoolResource>(new HDInsightClusterPoolOperationSource(Client), _hdInsightClusterPoolClusterPoolsClientDiagnostics, Pipeline, _hdInsightClusterPoolClusterPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        public virtual async Task<Response<HDInsightClusterPoolResource>> GetAsync(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterPoolName, nameof(clusterPoolName));

            using var scope = _hdInsightClusterPoolClusterPoolsClientDiagnostics.CreateScope("HDInsightClusterPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _hdInsightClusterPoolClusterPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HDInsightClusterPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        public virtual Response<HDInsightClusterPoolResource> Get(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterPoolName, nameof(clusterPoolName));

            using var scope = _hdInsightClusterPoolClusterPoolsClientDiagnostics.CreateScope("HDInsightClusterPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _hdInsightClusterPoolClusterPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HDInsightClusterPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the HDInsight cluster pools under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HDInsightClusterPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HDInsightClusterPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hdInsightClusterPoolClusterPoolsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hdInsightClusterPoolClusterPoolsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HDInsightClusterPoolResource(Client, HDInsightClusterPoolData.DeserializeHDInsightClusterPoolData(e)), _hdInsightClusterPoolClusterPoolsClientDiagnostics, Pipeline, "HDInsightClusterPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the HDInsight cluster pools under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HDInsightClusterPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HDInsightClusterPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hdInsightClusterPoolClusterPoolsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hdInsightClusterPoolClusterPoolsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HDInsightClusterPoolResource(Client, HDInsightClusterPoolData.DeserializeHDInsightClusterPoolData(e)), _hdInsightClusterPoolClusterPoolsClientDiagnostics, Pipeline, "HDInsightClusterPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterPoolName, nameof(clusterPoolName));

            using var scope = _hdInsightClusterPoolClusterPoolsClientDiagnostics.CreateScope("HDInsightClusterPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hdInsightClusterPoolClusterPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterPoolName, nameof(clusterPoolName));

            using var scope = _hdInsightClusterPoolClusterPoolsClientDiagnostics.CreateScope("HDInsightClusterPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _hdInsightClusterPoolClusterPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        public virtual async Task<NullableResponse<HDInsightClusterPoolResource>> GetIfExistsAsync(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterPoolName, nameof(clusterPoolName));

            using var scope = _hdInsightClusterPoolClusterPoolsClientDiagnostics.CreateScope("HDInsightClusterPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hdInsightClusterPoolClusterPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HDInsightClusterPoolResource>(response.GetRawResponse());
                return Response.FromValue(new HDInsightClusterPoolResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        public virtual NullableResponse<HDInsightClusterPoolResource> GetIfExists(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterPoolName, nameof(clusterPoolName));

            using var scope = _hdInsightClusterPoolClusterPoolsClientDiagnostics.CreateScope("HDInsightClusterPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hdInsightClusterPoolClusterPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HDInsightClusterPoolResource>(response.GetRawResponse());
                return Response.FromValue(new HDInsightClusterPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HDInsightClusterPoolResource> IEnumerable<HDInsightClusterPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HDInsightClusterPoolResource> IAsyncEnumerable<HDInsightClusterPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
