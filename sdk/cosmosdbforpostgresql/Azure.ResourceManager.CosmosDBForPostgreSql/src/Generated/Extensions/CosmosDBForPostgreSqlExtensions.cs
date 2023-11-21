// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDBForPostgreSql.Mocking;
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.CosmosDBForPostgreSql. </summary>
    public static partial class CosmosDBForPostgreSqlExtensions
    {
        private static MockableCosmosDBForPostgreSqlArmClient GetMockableCosmosDBForPostgreSqlArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableCosmosDBForPostgreSqlArmClient(client0));
        }

        private static MockableCosmosDBForPostgreSqlResourceGroupResource GetMockableCosmosDBForPostgreSqlResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableCosmosDBForPostgreSqlResourceGroupResource(client, resource.Id));
        }

        private static MockableCosmosDBForPostgreSqlSubscriptionResource GetMockableCosmosDBForPostgreSqlSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableCosmosDBForPostgreSqlSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBForPostgreSqlClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBForPostgreSqlClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlArmClient.GetCosmosDBForPostgreSqlClusterResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CosmosDBForPostgreSqlClusterResource"/> object. </returns>
        public static CosmosDBForPostgreSqlClusterResource GetCosmosDBForPostgreSqlClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCosmosDBForPostgreSqlArmClient(client).GetCosmosDBForPostgreSqlClusterResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBForPostgreSqlClusterServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBForPostgreSqlClusterServerResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBForPostgreSqlClusterServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlArmClient.GetCosmosDBForPostgreSqlClusterServerResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CosmosDBForPostgreSqlClusterServerResource"/> object. </returns>
        public static CosmosDBForPostgreSqlClusterServerResource GetCosmosDBForPostgreSqlClusterServerResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCosmosDBForPostgreSqlArmClient(client).GetCosmosDBForPostgreSqlClusterServerResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBForPostgreSqlConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBForPostgreSqlConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBForPostgreSqlConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlArmClient.GetCosmosDBForPostgreSqlConfigurationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CosmosDBForPostgreSqlConfigurationResource"/> object. </returns>
        public static CosmosDBForPostgreSqlConfigurationResource GetCosmosDBForPostgreSqlConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCosmosDBForPostgreSqlArmClient(client).GetCosmosDBForPostgreSqlConfigurationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBForPostgreSqlCoordinatorConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBForPostgreSqlCoordinatorConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBForPostgreSqlCoordinatorConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlArmClient.GetCosmosDBForPostgreSqlCoordinatorConfigurationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CosmosDBForPostgreSqlCoordinatorConfigurationResource"/> object. </returns>
        public static CosmosDBForPostgreSqlCoordinatorConfigurationResource GetCosmosDBForPostgreSqlCoordinatorConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCosmosDBForPostgreSqlArmClient(client).GetCosmosDBForPostgreSqlCoordinatorConfigurationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBForPostgreSqlNodeConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBForPostgreSqlNodeConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBForPostgreSqlNodeConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlArmClient.GetCosmosDBForPostgreSqlNodeConfigurationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CosmosDBForPostgreSqlNodeConfigurationResource"/> object. </returns>
        public static CosmosDBForPostgreSqlNodeConfigurationResource GetCosmosDBForPostgreSqlNodeConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCosmosDBForPostgreSqlArmClient(client).GetCosmosDBForPostgreSqlNodeConfigurationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBForPostgreSqlFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBForPostgreSqlFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBForPostgreSqlFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlArmClient.GetCosmosDBForPostgreSqlFirewallRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CosmosDBForPostgreSqlFirewallRuleResource"/> object. </returns>
        public static CosmosDBForPostgreSqlFirewallRuleResource GetCosmosDBForPostgreSqlFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCosmosDBForPostgreSqlArmClient(client).GetCosmosDBForPostgreSqlFirewallRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBForPostgreSqlRoleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBForPostgreSqlRoleResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBForPostgreSqlRoleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlArmClient.GetCosmosDBForPostgreSqlRoleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CosmosDBForPostgreSqlRoleResource"/> object. </returns>
        public static CosmosDBForPostgreSqlRoleResource GetCosmosDBForPostgreSqlRoleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCosmosDBForPostgreSqlArmClient(client).GetCosmosDBForPostgreSqlRoleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlArmClient.GetCosmosDBForPostgreSqlPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionResource"/> object. </returns>
        public static CosmosDBForPostgreSqlPrivateEndpointConnectionResource GetCosmosDBForPostgreSqlPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCosmosDBForPostgreSqlArmClient(client).GetCosmosDBForPostgreSqlPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBForPostgreSqlPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBForPostgreSqlPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBForPostgreSqlPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlArmClient.GetCosmosDBForPostgreSqlPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CosmosDBForPostgreSqlPrivateLinkResource"/> object. </returns>
        public static CosmosDBForPostgreSqlPrivateLinkResource GetCosmosDBForPostgreSqlPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCosmosDBForPostgreSqlArmClient(client).GetCosmosDBForPostgreSqlPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets a collection of CosmosDBForPostgreSqlClusterResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlResourceGroupResource.GetCosmosDBForPostgreSqlClusters()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of CosmosDBForPostgreSqlClusterResources and their operations over a CosmosDBForPostgreSqlClusterResource. </returns>
        public static CosmosDBForPostgreSqlClusterCollection GetCosmosDBForPostgreSqlClusters(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableCosmosDBForPostgreSqlResourceGroupResource(resourceGroupResource).GetCosmosDBForPostgreSqlClusters();
        }

        /// <summary>
        /// Gets information about a cluster such as compute and storage configuration and cluster lifecycle metadata such as cluster creation date and time.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlResourceGroupResource.GetCosmosDBForPostgreSqlClusterAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<CosmosDBForPostgreSqlClusterResource>> GetCosmosDBForPostgreSqlClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableCosmosDBForPostgreSqlResourceGroupResource(resourceGroupResource).GetCosmosDBForPostgreSqlClusterAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a cluster such as compute and storage configuration and cluster lifecycle metadata such as cluster creation date and time.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlResourceGroupResource.GetCosmosDBForPostgreSqlCluster(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<CosmosDBForPostgreSqlClusterResource> GetCosmosDBForPostgreSqlCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableCosmosDBForPostgreSqlResourceGroupResource(resourceGroupResource).GetCosmosDBForPostgreSqlCluster(clusterName, cancellationToken);
        }

        /// <summary>
        /// Lists all clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlSubscriptionResource.GetCosmosDBForPostgreSqlClusters(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="CosmosDBForPostgreSqlClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<CosmosDBForPostgreSqlClusterResource> GetCosmosDBForPostgreSqlClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCosmosDBForPostgreSqlSubscriptionResource(subscriptionResource).GetCosmosDBForPostgreSqlClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlSubscriptionResource.GetCosmosDBForPostgreSqlClusters(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="CosmosDBForPostgreSqlClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<CosmosDBForPostgreSqlClusterResource> GetCosmosDBForPostgreSqlClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCosmosDBForPostgreSqlSubscriptionResource(subscriptionResource).GetCosmosDBForPostgreSqlClusters(cancellationToken);
        }

        /// <summary>
        /// Checks availability of a cluster name. Cluster names should be globally unique; at least 3 characters and at most 40 characters long; they must only contain lowercase letters, numbers, and hyphens; and must not start or end with a hyphen.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlSubscriptionResource.CheckCosmosDBForPostgreSqlClusterNameAvailability(CosmosDBForPostgreSqlClusterNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if cluster name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<CosmosDBForPostgreSqlClusterNameAvailabilityResult>> CheckCosmosDBForPostgreSqlClusterNameAvailabilityAsync(this SubscriptionResource subscriptionResource, CosmosDBForPostgreSqlClusterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableCosmosDBForPostgreSqlSubscriptionResource(subscriptionResource).CheckCosmosDBForPostgreSqlClusterNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks availability of a cluster name. Cluster names should be globally unique; at least 3 characters and at most 40 characters long; they must only contain lowercase letters, numbers, and hyphens; and must not start or end with a hyphen.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCosmosDBForPostgreSqlSubscriptionResource.CheckCosmosDBForPostgreSqlClusterNameAvailability(CosmosDBForPostgreSqlClusterNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if cluster name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<CosmosDBForPostgreSqlClusterNameAvailabilityResult> CheckCosmosDBForPostgreSqlClusterNameAvailability(this SubscriptionResource subscriptionResource, CosmosDBForPostgreSqlClusterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCosmosDBForPostgreSqlSubscriptionResource(subscriptionResource).CheckCosmosDBForPostgreSqlClusterNameAvailability(content, cancellationToken);
        }
    }
}
