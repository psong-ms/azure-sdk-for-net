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

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="LogAnalyticsQueryResource"/> and their operations.
    /// Each <see cref="LogAnalyticsQueryResource"/> in the collection will belong to the same instance of <see cref="LogAnalyticsQueryPackResource"/>.
    /// To get a <see cref="LogAnalyticsQueryCollection"/> instance call the GetLogAnalyticsQueries method from an instance of <see cref="LogAnalyticsQueryPackResource"/>.
    /// </summary>
    public partial class LogAnalyticsQueryCollection : ArmCollection, IEnumerable<LogAnalyticsQueryResource>, IAsyncEnumerable<LogAnalyticsQueryResource>
    {
        private readonly ClientDiagnostics _logAnalyticsQueryQueriesClientDiagnostics;
        private readonly QueriesRestOperations _logAnalyticsQueryQueriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogAnalyticsQueryCollection"/> class for mocking. </summary>
        protected LogAnalyticsQueryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogAnalyticsQueryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogAnalyticsQueryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logAnalyticsQueryQueriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", LogAnalyticsQueryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogAnalyticsQueryResource.ResourceType, out string logAnalyticsQueryQueriesApiVersion);
            _logAnalyticsQueryQueriesRestClient = new QueriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logAnalyticsQueryQueriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LogAnalyticsQueryPackResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LogAnalyticsQueryPackResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds or Updates a specific Query within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The id of a specific query defined in the Log Analytics QueryPack. </param>
        /// <param name="data"> Properties that need to be specified to create a new query and add it to a Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LogAnalyticsQueryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string id, LogAnalyticsQueryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _logAnalyticsQueryQueriesRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken).ConfigureAwait(false);
                var operation = new OperationalInsightsArmOperation<LogAnalyticsQueryResource>(Response.FromValue(new LogAnalyticsQueryResource(Client, response), response.GetRawResponse()));
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
        /// Adds or Updates a specific Query within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The id of a specific query defined in the Log Analytics QueryPack. </param>
        /// <param name="data"> Properties that need to be specified to create a new query and add it to a Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LogAnalyticsQueryResource> CreateOrUpdate(WaitUntil waitUntil, string id, LogAnalyticsQueryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _logAnalyticsQueryQueriesRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken);
                var operation = new OperationalInsightsArmOperation<LogAnalyticsQueryResource>(Response.FromValue(new LogAnalyticsQueryResource(Client, response), response.GetRawResponse()));
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
        /// Gets a specific Log Analytics Query defined within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The id of a specific query defined in the Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<LogAnalyticsQueryResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryCollection.Get");
            scope.Start();
            try
            {
                var response = await _logAnalyticsQueryQueriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogAnalyticsQueryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific Log Analytics Query defined within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The id of a specific query defined in the Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<LogAnalyticsQueryResource> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryCollection.Get");
            scope.Start();
            try
            {
                var response = _logAnalyticsQueryQueriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogAnalyticsQueryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Queries defined within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Maximum items returned in page. </param>
        /// <param name="includeBody"> Flag indicating whether or not to return the body of each applicable query. If false, only return the query information. </param>
        /// <param name="skipToken"> Base64 encoded token used to fetch the next page of items. Default is null. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogAnalyticsQueryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogAnalyticsQueryResource> GetAllAsync(long? top = null, bool? includeBody = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logAnalyticsQueryQueriesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, includeBody, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logAnalyticsQueryQueriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, includeBody, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LogAnalyticsQueryResource(Client, LogAnalyticsQueryData.DeserializeLogAnalyticsQueryData(e)), _logAnalyticsQueryQueriesClientDiagnostics, Pipeline, "LogAnalyticsQueryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Queries defined within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Maximum items returned in page. </param>
        /// <param name="includeBody"> Flag indicating whether or not to return the body of each applicable query. If false, only return the query information. </param>
        /// <param name="skipToken"> Base64 encoded token used to fetch the next page of items. Default is null. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogAnalyticsQueryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogAnalyticsQueryResource> GetAll(long? top = null, bool? includeBody = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logAnalyticsQueryQueriesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, includeBody, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logAnalyticsQueryQueriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, includeBody, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LogAnalyticsQueryResource(Client, LogAnalyticsQueryData.DeserializeLogAnalyticsQueryData(e)), _logAnalyticsQueryQueriesClientDiagnostics, Pipeline, "LogAnalyticsQueryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The id of a specific query defined in the Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logAnalyticsQueryQueriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The id of a specific query defined in the Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryCollection.Exists");
            scope.Start();
            try
            {
                var response = _logAnalyticsQueryQueriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The id of a specific query defined in the Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<NullableResponse<LogAnalyticsQueryResource>> GetIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logAnalyticsQueryQueriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LogAnalyticsQueryResource>(response.GetRawResponse());
                return Response.FromValue(new LogAnalyticsQueryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The id of a specific query defined in the Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual NullableResponse<LogAnalyticsQueryResource> GetIfExists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logAnalyticsQueryQueriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LogAnalyticsQueryResource>(response.GetRawResponse());
                return Response.FromValue(new LogAnalyticsQueryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogAnalyticsQueryResource> IEnumerable<LogAnalyticsQueryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogAnalyticsQueryResource> IAsyncEnumerable<LogAnalyticsQueryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
