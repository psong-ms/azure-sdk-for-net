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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkloadNetworkVirtualMachineResource"/> and their operations.
    /// Each <see cref="WorkloadNetworkVirtualMachineResource"/> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource"/>.
    /// To get a <see cref="WorkloadNetworkVirtualMachineCollection"/> instance call the GetWorkloadNetworkVirtualMachines method from an instance of <see cref="AvsPrivateCloudResource"/>.
    /// </summary>
    public partial class WorkloadNetworkVirtualMachineCollection : ArmCollection, IEnumerable<WorkloadNetworkVirtualMachineResource>, IAsyncEnumerable<WorkloadNetworkVirtualMachineResource>
    {
        private readonly ClientDiagnostics _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkVirtualMachineWorkloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkVirtualMachineCollection"/> class for mocking. </summary>
        protected WorkloadNetworkVirtualMachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkVirtualMachineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadNetworkVirtualMachineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", WorkloadNetworkVirtualMachineResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadNetworkVirtualMachineResource.ResourceType, out string workloadNetworkVirtualMachineWorkloadNetworksApiVersion);
            _workloadNetworkVirtualMachineWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkVirtualMachineWorkloadNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a virtual machine by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVirtualMachine</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public virtual async Task<Response<WorkloadNetworkVirtualMachineResource>> GetAsync(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVirtualMachineWorkloadNetworksRestClient.GetVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a virtual machine by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVirtualMachine</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public virtual Response<WorkloadNetworkVirtualMachineResource> Get(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkVirtualMachineWorkloadNetworksRestClient.GetVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of virtual machines in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/virtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListVirtualMachines</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkVirtualMachineResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkVirtualMachineResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkVirtualMachineWorkloadNetworksRestClient.CreateListVirtualMachinesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkVirtualMachineWorkloadNetworksRestClient.CreateListVirtualMachinesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkloadNetworkVirtualMachineResource(Client, WorkloadNetworkVirtualMachineData.DeserializeWorkloadNetworkVirtualMachineData(e)), _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkVirtualMachineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtual machines in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/virtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListVirtualMachines</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkVirtualMachineResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkVirtualMachineResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkVirtualMachineWorkloadNetworksRestClient.CreateListVirtualMachinesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkVirtualMachineWorkloadNetworksRestClient.CreateListVirtualMachinesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkloadNetworkVirtualMachineResource(Client, WorkloadNetworkVirtualMachineData.DeserializeWorkloadNetworkVirtualMachineData(e)), _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkVirtualMachineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVirtualMachine</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVirtualMachineWorkloadNetworksRestClient.GetVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVirtualMachine</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadNetworkVirtualMachineWorkloadNetworksRestClient.GetVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVirtualMachine</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public virtual async Task<NullableResponse<WorkloadNetworkVirtualMachineResource>> GetIfExistsAsync(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVirtualMachineWorkloadNetworksRestClient.GetVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadNetworkVirtualMachineResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVirtualMachineResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/virtualMachines/{virtualMachineId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVirtualMachine</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public virtual NullableResponse<WorkloadNetworkVirtualMachineResource> GetIfExists(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var scope = _workloadNetworkVirtualMachineWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workloadNetworkVirtualMachineWorkloadNetworksRestClient.GetVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadNetworkVirtualMachineResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadNetworkVirtualMachineResource> IEnumerable<WorkloadNetworkVirtualMachineResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkVirtualMachineResource> IAsyncEnumerable<WorkloadNetworkVirtualMachineResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
