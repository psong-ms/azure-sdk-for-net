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

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A class representing a collection of <see cref="FhirServiceResource"/> and their operations.
    /// Each <see cref="FhirServiceResource"/> in the collection will belong to the same instance of <see cref="HealthcareApisWorkspaceResource"/>.
    /// To get a <see cref="FhirServiceCollection"/> instance call the GetFhirServices method from an instance of <see cref="HealthcareApisWorkspaceResource"/>.
    /// </summary>
    public partial class FhirServiceCollection : ArmCollection, IEnumerable<FhirServiceResource>, IAsyncEnumerable<FhirServiceResource>
    {
        private readonly ClientDiagnostics _fhirServiceClientDiagnostics;
        private readonly FhirServicesRestOperations _fhirServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="FhirServiceCollection"/> class for mocking. </summary>
        protected FhirServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FhirServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FhirServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fhirServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", FhirServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FhirServiceResource.ResourceType, out string fhirServiceApiVersion);
            _fhirServiceRestClient = new FhirServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fhirServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HealthcareApisWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HealthcareApisWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a FHIR Service resource with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices/{fhirServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="data"> The parameters for creating or updating a Fhir Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FhirServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fhirServiceName, FhirServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirServiceName, nameof(fhirServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fhirServiceClientDiagnostics.CreateScope("FhirServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fhirServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation<FhirServiceResource>(new FhirServiceOperationSource(Client), _fhirServiceClientDiagnostics, Pipeline, _fhirServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a FHIR Service resource with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices/{fhirServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="data"> The parameters for creating or updating a Fhir Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FhirServiceResource> CreateOrUpdate(WaitUntil waitUntil, string fhirServiceName, FhirServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirServiceName, nameof(fhirServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fhirServiceClientDiagnostics.CreateScope("FhirServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fhirServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, data, cancellationToken);
                var operation = new HealthcareApisArmOperation<FhirServiceResource>(new FhirServiceOperationSource(Client), _fhirServiceClientDiagnostics, Pipeline, _fhirServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the properties of the specified FHIR Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices/{fhirServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceName"/> is null. </exception>
        public virtual async Task<Response<FhirServiceResource>> GetAsync(string fhirServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirServiceName, nameof(fhirServiceName));

            using var scope = _fhirServiceClientDiagnostics.CreateScope("FhirServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _fhirServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FhirServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified FHIR Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices/{fhirServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceName"/> is null. </exception>
        public virtual Response<FhirServiceResource> Get(string fhirServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirServiceName, nameof(fhirServiceName));

            using var scope = _fhirServiceClientDiagnostics.CreateScope("FhirServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _fhirServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FhirServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all FHIR Services for the given workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FhirServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FhirServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fhirServiceRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fhirServiceRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FhirServiceResource(Client, FhirServiceData.DeserializeFhirServiceData(e)), _fhirServiceClientDiagnostics, Pipeline, "FhirServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all FHIR Services for the given workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FhirServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FhirServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fhirServiceRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fhirServiceRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FhirServiceResource(Client, FhirServiceData.DeserializeFhirServiceData(e)), _fhirServiceClientDiagnostics, Pipeline, "FhirServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices/{fhirServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fhirServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirServiceName, nameof(fhirServiceName));

            using var scope = _fhirServiceClientDiagnostics.CreateScope("FhirServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _fhirServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices/{fhirServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string fhirServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirServiceName, nameof(fhirServiceName));

            using var scope = _fhirServiceClientDiagnostics.CreateScope("FhirServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _fhirServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices/{fhirServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceName"/> is null. </exception>
        public virtual async Task<NullableResponse<FhirServiceResource>> GetIfExistsAsync(string fhirServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirServiceName, nameof(fhirServiceName));

            using var scope = _fhirServiceClientDiagnostics.CreateScope("FhirServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _fhirServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FhirServiceResource>(response.GetRawResponse());
                return Response.FromValue(new FhirServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/fhirservices/{fhirServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FhirServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fhirServiceName"> The name of FHIR Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceName"/> is null. </exception>
        public virtual NullableResponse<FhirServiceResource> GetIfExists(string fhirServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirServiceName, nameof(fhirServiceName));

            using var scope = _fhirServiceClientDiagnostics.CreateScope("FhirServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fhirServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fhirServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FhirServiceResource>(response.GetRawResponse());
                return Response.FromValue(new FhirServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FhirServiceResource> IEnumerable<FhirServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FhirServiceResource> IAsyncEnumerable<FhirServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
