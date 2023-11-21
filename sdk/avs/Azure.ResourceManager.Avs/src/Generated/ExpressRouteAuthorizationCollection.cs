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
    /// A class representing a collection of <see cref="ExpressRouteAuthorizationResource"/> and their operations.
    /// Each <see cref="ExpressRouteAuthorizationResource"/> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource"/>.
    /// To get an <see cref="ExpressRouteAuthorizationCollection"/> instance call the GetExpressRouteAuthorizations method from an instance of <see cref="AvsPrivateCloudResource"/>.
    /// </summary>
    public partial class ExpressRouteAuthorizationCollection : ArmCollection, IEnumerable<ExpressRouteAuthorizationResource>, IAsyncEnumerable<ExpressRouteAuthorizationResource>
    {
        private readonly ClientDiagnostics _expressRouteAuthorizationAuthorizationsClientDiagnostics;
        private readonly AuthorizationsRestOperations _expressRouteAuthorizationAuthorizationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteAuthorizationCollection"/> class for mocking. </summary>
        protected ExpressRouteAuthorizationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteAuthorizationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteAuthorizationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteAuthorizationAuthorizationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ExpressRouteAuthorizationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteAuthorizationResource.ResourceType, out string expressRouteAuthorizationAuthorizationsApiVersion);
            _expressRouteAuthorizationAuthorizationsRestClient = new AuthorizationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteAuthorizationAuthorizationsApiVersion);
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
        /// Create or update an ExpressRoute Circuit Authorization in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationName"> Name of the ExpressRoute Circuit Authorization in the private cloud. </param>
        /// <param name="data"> An ExpressRoute Circuit Authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteAuthorizationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationName, ExpressRouteAuthorizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteAuthorizationAuthorizationsClientDiagnostics.CreateScope("ExpressRouteAuthorizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteAuthorizationAuthorizationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<ExpressRouteAuthorizationResource>(new ExpressRouteAuthorizationOperationSource(Client), _expressRouteAuthorizationAuthorizationsClientDiagnostics, Pipeline, _expressRouteAuthorizationAuthorizationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an ExpressRoute Circuit Authorization in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationName"> Name of the ExpressRoute Circuit Authorization in the private cloud. </param>
        /// <param name="data"> An ExpressRoute Circuit Authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteAuthorizationResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationName, ExpressRouteAuthorizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteAuthorizationAuthorizationsClientDiagnostics.CreateScope("ExpressRouteAuthorizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteAuthorizationAuthorizationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data, cancellationToken);
                var operation = new AvsArmOperation<ExpressRouteAuthorizationResource>(new ExpressRouteAuthorizationOperationSource(Client), _expressRouteAuthorizationAuthorizationsClientDiagnostics, Pipeline, _expressRouteAuthorizationAuthorizationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get an ExpressRoute Circuit Authorization by name in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> Name of the ExpressRoute Circuit Authorization in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteAuthorizationResource>> GetAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteAuthorizationAuthorizationsClientDiagnostics.CreateScope("ExpressRouteAuthorizationCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteAuthorizationAuthorizationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteAuthorizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an ExpressRoute Circuit Authorization by name in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> Name of the ExpressRoute Circuit Authorization in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual Response<ExpressRouteAuthorizationResource> Get(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteAuthorizationAuthorizationsClientDiagnostics.CreateScope("ExpressRouteAuthorizationCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteAuthorizationAuthorizationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteAuthorizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List ExpressRoute Circuit Authorizations in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteAuthorizationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteAuthorizationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteAuthorizationAuthorizationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteAuthorizationAuthorizationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteAuthorizationResource(Client, ExpressRouteAuthorizationData.DeserializeExpressRouteAuthorizationData(e)), _expressRouteAuthorizationAuthorizationsClientDiagnostics, Pipeline, "ExpressRouteAuthorizationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List ExpressRoute Circuit Authorizations in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteAuthorizationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteAuthorizationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteAuthorizationAuthorizationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteAuthorizationAuthorizationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteAuthorizationResource(Client, ExpressRouteAuthorizationData.DeserializeExpressRouteAuthorizationData(e)), _expressRouteAuthorizationAuthorizationsClientDiagnostics, Pipeline, "ExpressRouteAuthorizationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> Name of the ExpressRoute Circuit Authorization in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteAuthorizationAuthorizationsClientDiagnostics.CreateScope("ExpressRouteAuthorizationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteAuthorizationAuthorizationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> Name of the ExpressRoute Circuit Authorization in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteAuthorizationAuthorizationsClientDiagnostics.CreateScope("ExpressRouteAuthorizationCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteAuthorizationAuthorizationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> Name of the ExpressRoute Circuit Authorization in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<NullableResponse<ExpressRouteAuthorizationResource>> GetIfExistsAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteAuthorizationAuthorizationsClientDiagnostics.CreateScope("ExpressRouteAuthorizationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteAuthorizationAuthorizationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteAuthorizationResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteAuthorizationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Authorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> Name of the ExpressRoute Circuit Authorization in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual NullableResponse<ExpressRouteAuthorizationResource> GetIfExists(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRouteAuthorizationAuthorizationsClientDiagnostics.CreateScope("ExpressRouteAuthorizationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteAuthorizationAuthorizationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteAuthorizationResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteAuthorizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteAuthorizationResource> IEnumerable<ExpressRouteAuthorizationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteAuthorizationResource> IAsyncEnumerable<ExpressRouteAuthorizationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
