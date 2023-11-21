// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Quantum;
using Azure.ResourceManager.Quantum.Models;

namespace Azure.ResourceManager.Quantum.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableQuantumSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _quantumWorkspaceWorkspacesClientDiagnostics;
        private WorkspacesRestOperations _quantumWorkspaceWorkspacesRestClient;
        private ClientDiagnostics _offeringsClientDiagnostics;
        private OfferingsRestOperations _offeringsRestClient;
        private ClientDiagnostics _workspaceClientDiagnostics;
        private WorkspaceRestOperations _workspaceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableQuantumSubscriptionResource"/> class for mocking. </summary>
        protected MockableQuantumSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableQuantumSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableQuantumSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics QuantumWorkspaceWorkspacesClientDiagnostics => _quantumWorkspaceWorkspacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Quantum", QuantumWorkspaceResource.ResourceType.Namespace, Diagnostics);
        private WorkspacesRestOperations QuantumWorkspaceWorkspacesRestClient => _quantumWorkspaceWorkspacesRestClient ??= new WorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(QuantumWorkspaceResource.ResourceType));
        private ClientDiagnostics OfferingsClientDiagnostics => _offeringsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Quantum", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OfferingsRestOperations OfferingsRestClient => _offeringsRestClient ??= new OfferingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics WorkspaceClientDiagnostics => _workspaceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Quantum", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private WorkspaceRestOperations WorkspaceRestClient => _workspaceRestClient ??= new WorkspaceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets the list of Workspaces within a Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Quantum/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QuantumWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<QuantumWorkspaceResource> GetQuantumWorkspacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => QuantumWorkspaceWorkspacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => QuantumWorkspaceWorkspacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new QuantumWorkspaceResource(Client, QuantumWorkspaceData.DeserializeQuantumWorkspaceData(e)), QuantumWorkspaceWorkspacesClientDiagnostics, Pipeline, "MockableQuantumSubscriptionResource.GetQuantumWorkspaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Workspaces within a Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Quantum/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QuantumWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<QuantumWorkspaceResource> GetQuantumWorkspaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => QuantumWorkspaceWorkspacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => QuantumWorkspaceWorkspacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new QuantumWorkspaceResource(Client, QuantumWorkspaceData.DeserializeQuantumWorkspaceData(e)), QuantumWorkspaceWorkspacesClientDiagnostics, Pipeline, "MockableQuantumSubscriptionResource.GetQuantumWorkspaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns the list of all provider offerings available for the given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Quantum/locations/{locationName}/offerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Offerings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProviderDescription"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderDescription> GetOfferingsAsync(string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => OfferingsRestClient.CreateListRequest(Id.SubscriptionId, locationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OfferingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, locationName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ProviderDescription.DeserializeProviderDescription, OfferingsClientDiagnostics, Pipeline, "MockableQuantumSubscriptionResource.GetOfferings", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns the list of all provider offerings available for the given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Quantum/locations/{locationName}/offerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Offerings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> A collection of <see cref="ProviderDescription"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderDescription> GetOfferings(string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => OfferingsRestClient.CreateListRequest(Id.SubscriptionId, locationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OfferingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, locationName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ProviderDescription.DeserializeProviderDescription, OfferingsClientDiagnostics, Pipeline, "MockableQuantumSubscriptionResource.GetOfferings", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Quantum/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspace_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Location. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityWorkspaceAsync(string locationName, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = WorkspaceClientDiagnostics.CreateScope("MockableQuantumSubscriptionResource.CheckNameAvailabilityWorkspace");
            scope.Start();
            try
            {
                var response = await WorkspaceRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, locationName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Quantum/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspace_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Location. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public virtual Response<CheckNameAvailabilityResult> CheckNameAvailabilityWorkspace(string locationName, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = WorkspaceClientDiagnostics.CreateScope("MockableQuantumSubscriptionResource.CheckNameAvailabilityWorkspace");
            scope.Start();
            try
            {
                var response = WorkspaceRestClient.CheckNameAvailability(Id.SubscriptionId, locationName, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
