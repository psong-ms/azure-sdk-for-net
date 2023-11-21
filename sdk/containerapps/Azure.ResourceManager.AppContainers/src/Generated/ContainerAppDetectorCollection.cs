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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppDetectorResource"/> and their operations.
    /// Each <see cref="ContainerAppDetectorResource"/> in the collection will belong to the same instance of <see cref="ContainerAppResource"/>.
    /// To get a <see cref="ContainerAppDetectorCollection"/> instance call the GetContainerAppDetectors method from an instance of <see cref="ContainerAppResource"/>.
    /// </summary>
    public partial class ContainerAppDetectorCollection : ArmCollection, IEnumerable<ContainerAppDetectorResource>, IAsyncEnumerable<ContainerAppDetectorResource>
    {
        private readonly ClientDiagnostics _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics;
        private readonly ContainerAppsDiagnosticsRestOperations _containerAppDetectorContainerAppsDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppDetectorCollection"/> class for mocking. </summary>
        protected ContainerAppDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppDetectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppDetectorResource.ResourceType, out string containerAppDetectorContainerAppsDiagnosticsApiVersion);
            _containerAppDetectorContainerAppsDiagnosticsRestClient = new ContainerAppsDiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppDetectorContainerAppsDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a diagnostics result of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetDetector</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Container App Detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppDetectorResource>> GetAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppDetectorContainerAppsDiagnosticsRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a diagnostics result of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetDetector</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Container App Detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<ContainerAppDetectorResource> Get(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppDetectorContainerAppsDiagnosticsRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the list of diagnostics for a given Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_ListDetectors</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppDetectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppDetectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppDetectorContainerAppsDiagnosticsRestClient.CreateListDetectorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppDetectorContainerAppsDiagnosticsRestClient.CreateListDetectorsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppDetectorResource(Client, ContainerAppDiagnosticData.DeserializeContainerAppDiagnosticData(e)), _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics, Pipeline, "ContainerAppDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the list of diagnostics for a given Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_ListDetectors</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppDetectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppDetectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppDetectorContainerAppsDiagnosticsRestClient.CreateListDetectorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppDetectorContainerAppsDiagnosticsRestClient.CreateListDetectorsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppDetectorResource(Client, ContainerAppDiagnosticData.DeserializeContainerAppDiagnosticData(e)), _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics, Pipeline, "ContainerAppDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetDetector</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Container App Detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppDetectorContainerAppsDiagnosticsRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetDetector</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Container App Detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppDetectorContainerAppsDiagnosticsRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetDetector</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Container App Detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppDetectorResource>> GetIfExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppDetectorContainerAppsDiagnosticsRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppDetectorResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppDetectorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsDiagnostics_GetDetector</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Container App Detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppDetectorResource> GetIfExists(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppDetectorContainerAppsDiagnosticsClientDiagnostics.CreateScope("ContainerAppDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppDetectorContainerAppsDiagnosticsRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppDetectorResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppDetectorResource> IEnumerable<ContainerAppDetectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppDetectorResource> IAsyncEnumerable<ContainerAppDetectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
