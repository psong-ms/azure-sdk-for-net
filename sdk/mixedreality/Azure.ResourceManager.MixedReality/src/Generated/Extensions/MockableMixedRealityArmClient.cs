// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MixedReality;

namespace Azure.ResourceManager.MixedReality.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableMixedRealityArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMixedRealityArmClient"/> class for mocking. </summary>
        protected MockableMixedRealityArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMixedRealityArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMixedRealityArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableMixedRealityArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="SpatialAnchorsAccountResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SpatialAnchorsAccountResource.CreateResourceIdentifier" /> to create a <see cref="SpatialAnchorsAccountResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SpatialAnchorsAccountResource"/> object. </returns>
        public virtual SpatialAnchorsAccountResource GetSpatialAnchorsAccountResource(ResourceIdentifier id)
        {
            SpatialAnchorsAccountResource.ValidateResourceId(id);
            return new SpatialAnchorsAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RemoteRenderingAccountResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RemoteRenderingAccountResource.CreateResourceIdentifier" /> to create a <see cref="RemoteRenderingAccountResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RemoteRenderingAccountResource"/> object. </returns>
        public virtual RemoteRenderingAccountResource GetRemoteRenderingAccountResource(ResourceIdentifier id)
        {
            RemoteRenderingAccountResource.ValidateResourceId(id);
            return new RemoteRenderingAccountResource(Client, id);
        }
    }
}
