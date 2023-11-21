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

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A Class representing a WidgetTypeResourceFormat along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="WidgetTypeResourceFormatResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetWidgetTypeResourceFormatResource method.
    /// Otherwise you can get one from its parent resource <see cref="HubResource"/> using the GetWidgetTypeResourceFormat method.
    /// </summary>
    public partial class WidgetTypeResourceFormatResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WidgetTypeResourceFormatResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="hubName"> The hubName. </param>
        /// <param name="widgetTypeName"> The widgetTypeName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hubName, string widgetTypeName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/widgetTypes/{widgetTypeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _widgetTypeResourceFormatWidgetTypesClientDiagnostics;
        private readonly WidgetTypesRestOperations _widgetTypeResourceFormatWidgetTypesRestClient;
        private readonly WidgetTypeResourceFormatData _data;

        /// <summary> Initializes a new instance of the <see cref="WidgetTypeResourceFormatResource"/> class for mocking. </summary>
        protected WidgetTypeResourceFormatResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WidgetTypeResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WidgetTypeResourceFormatResource(ArmClient client, WidgetTypeResourceFormatData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WidgetTypeResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WidgetTypeResourceFormatResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _widgetTypeResourceFormatWidgetTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string widgetTypeResourceFormatWidgetTypesApiVersion);
            _widgetTypeResourceFormatWidgetTypesRestClient = new WidgetTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, widgetTypeResourceFormatWidgetTypesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CustomerInsights/hubs/widgetTypes";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WidgetTypeResourceFormatData Data
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
        /// Gets a widget type in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/widgetTypes/{widgetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WidgetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WidgetTypeResourceFormatResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _widgetTypeResourceFormatWidgetTypesClientDiagnostics.CreateScope("WidgetTypeResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = await _widgetTypeResourceFormatWidgetTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WidgetTypeResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a widget type in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/widgetTypes/{widgetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WidgetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WidgetTypeResourceFormatResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _widgetTypeResourceFormatWidgetTypesClientDiagnostics.CreateScope("WidgetTypeResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = _widgetTypeResourceFormatWidgetTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WidgetTypeResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
