// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A Class representing a StorageSyncServerEndpoint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="StorageSyncServerEndpointResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetStorageSyncServerEndpointResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageSyncGroupResource"/> using the GetStorageSyncServerEndpoint method.
    /// </summary>
    public partial class StorageSyncServerEndpointResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StorageSyncServerEndpointResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="storageSyncServiceName"> The storageSyncServiceName. </param>
        /// <param name="syncGroupName"> The syncGroupName. </param>
        /// <param name="serverEndpointName"> The serverEndpointName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _storageSyncServerEndpointServerEndpointsClientDiagnostics;
        private readonly ServerEndpointsRestOperations _storageSyncServerEndpointServerEndpointsRestClient;
        private readonly StorageSyncServerEndpointData _data;

        /// <summary> Initializes a new instance of the <see cref="StorageSyncServerEndpointResource"/> class for mocking. </summary>
        protected StorageSyncServerEndpointResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSyncServerEndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StorageSyncServerEndpointResource(ArmClient client, StorageSyncServerEndpointData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSyncServerEndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageSyncServerEndpointResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageSyncServerEndpointServerEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string storageSyncServerEndpointServerEndpointsApiVersion);
            _storageSyncServerEndpointServerEndpointsRestClient = new ServerEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageSyncServerEndpointServerEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StorageSync/storageSyncServices/syncGroups/serverEndpoints";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StorageSyncServerEndpointData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageSyncServerEndpointResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointResource.Get");
            scope.Start();
            try
            {
                var response = await _storageSyncServerEndpointServerEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServerEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageSyncServerEndpointResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointResource.Get");
            scope.Start();
            try
            {
                var response = _storageSyncServerEndpointServerEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncServerEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a given ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointResource.Delete");
            scope.Start();
            try
            {
                var response = await _storageSyncServerEndpointServerEndpointsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation(_storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, _storageSyncServerEndpointServerEndpointsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a given ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointResource.Delete");
            scope.Start();
            try
            {
                var response = _storageSyncServerEndpointServerEndpointsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new StorageSyncArmOperation(_storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, _storageSyncServerEndpointServerEndpointsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Patch a given ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Any of the properties applicable in PUT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageSyncServerEndpointResource>> UpdateAsync(WaitUntil waitUntil, StorageSyncServerEndpointPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointResource.Update");
            scope.Start();
            try
            {
                var response = await _storageSyncServerEndpointServerEndpointsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation<StorageSyncServerEndpointResource>(new StorageSyncServerEndpointOperationSource(Client), _storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, _storageSyncServerEndpointServerEndpointsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Patch a given ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Any of the properties applicable in PUT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<StorageSyncServerEndpointResource> Update(WaitUntil waitUntil, StorageSyncServerEndpointPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointResource.Update");
            scope.Start();
            try
            {
                var response = _storageSyncServerEndpointServerEndpointsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new StorageSyncArmOperation<StorageSyncServerEndpointResource>(new StorageSyncServerEndpointOperationSource(Client), _storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, _storageSyncServerEndpointServerEndpointsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Recall a server endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}/recallAction</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_recallAction</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Body of Recall Action object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> RecallActionAsync(WaitUntil waitUntil, RecallActionContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointResource.RecallAction");
            scope.Start();
            try
            {
                var response = await _storageSyncServerEndpointServerEndpointsRestClient.RecallActionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation(_storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, _storageSyncServerEndpointServerEndpointsRestClient.CreateRecallActionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recall a server endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}/recallAction</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_recallAction</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Body of Recall Action object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation RecallAction(WaitUntil waitUntil, RecallActionContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncServerEndpointServerEndpointsClientDiagnostics.CreateScope("StorageSyncServerEndpointResource.RecallAction");
            scope.Start();
            try
            {
                var response = _storageSyncServerEndpointServerEndpointsRestClient.RecallAction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new StorageSyncArmOperation(_storageSyncServerEndpointServerEndpointsClientDiagnostics, Pipeline, _storageSyncServerEndpointServerEndpointsRestClient.CreateRecallActionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
