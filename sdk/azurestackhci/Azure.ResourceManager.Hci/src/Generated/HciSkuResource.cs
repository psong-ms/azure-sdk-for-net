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

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A Class representing a HciSku along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HciSkuResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHciSkuResource method.
    /// Otherwise you can get one from its parent resource <see cref="OfferResource"/> using the GetHciSku method.
    /// </summary>
    public partial class HciSkuResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HciSkuResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="clusterName"> The clusterName. </param>
        /// <param name="publisherName"> The publisherName. </param>
        /// <param name="offerName"> The offerName. </param>
        /// <param name="skuName"> The skuName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName, string publisherName, string offerName, string skuName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers/{publisherName}/offers/{offerName}/skus/{skuName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hciSkuSkusClientDiagnostics;
        private readonly SkusRestOperations _hciSkuSkusRestClient;
        private readonly HciSkuData _data;

        /// <summary> Initializes a new instance of the <see cref="HciSkuResource"/> class for mocking. </summary>
        protected HciSkuResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HciSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HciSkuResource(ArmClient client, HciSkuData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HciSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HciSkuResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hciSkuSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hciSkuSkusApiVersion);
            _hciSkuSkusRestClient = new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hciSkuSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AzureStackHCI/clusters/publishers/offers/skus";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HciSkuData Data
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
        /// Get SKU resource details within a offer of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers/{publisherName}/offers/{offerName}/skus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify $expand=content,contentVersion to populate additional fields related to the marketplace offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HciSkuResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _hciSkuSkusClientDiagnostics.CreateScope("HciSkuResource.Get");
            scope.Start();
            try
            {
                var response = await _hciSkuSkusRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get SKU resource details within a offer of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/publishers/{publisherName}/offers/{offerName}/skus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify $expand=content,contentVersion to populate additional fields related to the marketplace offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HciSkuResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _hciSkuSkusClientDiagnostics.CreateScope("HciSkuResource.Get");
            scope.Start();
            try
            {
                var response = _hciSkuSkusRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
