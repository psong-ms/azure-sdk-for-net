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
using Azure.ResourceManager.Communication.Mocking;
using Azure.ResourceManager.Communication.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Communication
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Communication. </summary>
    public static partial class CommunicationExtensions
    {
        private static MockableCommunicationArmClient GetMockableCommunicationArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableCommunicationArmClient(client0));
        }

        private static MockableCommunicationResourceGroupResource GetMockableCommunicationResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableCommunicationResourceGroupResource(client, resource.Id));
        }

        private static MockableCommunicationSubscriptionResource GetMockableCommunicationSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableCommunicationSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="CommunicationServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommunicationServiceResource.CreateResourceIdentifier" /> to create a <see cref="CommunicationServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationArmClient.GetCommunicationServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CommunicationServiceResource"/> object. </returns>
        public static CommunicationServiceResource GetCommunicationServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCommunicationArmClient(client).GetCommunicationServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CommunicationDomainResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommunicationDomainResource.CreateResourceIdentifier" /> to create a <see cref="CommunicationDomainResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationArmClient.GetCommunicationDomainResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CommunicationDomainResource"/> object. </returns>
        public static CommunicationDomainResource GetCommunicationDomainResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCommunicationArmClient(client).GetCommunicationDomainResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EmailServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EmailServiceResource.CreateResourceIdentifier" /> to create an <see cref="EmailServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationArmClient.GetEmailServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="EmailServiceResource"/> object. </returns>
        public static EmailServiceResource GetEmailServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCommunicationArmClient(client).GetEmailServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SenderUsernameResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SenderUsernameResource.CreateResourceIdentifier" /> to create a <see cref="SenderUsernameResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationArmClient.GetSenderUsernameResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SenderUsernameResource"/> object. </returns>
        public static SenderUsernameResource GetSenderUsernameResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCommunicationArmClient(client).GetSenderUsernameResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SuppressionListResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SuppressionListResource.CreateResourceIdentifier" /> to create a <see cref="SuppressionListResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationArmClient.GetSuppressionListResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SuppressionListResource"/> object. </returns>
        public static SuppressionListResource GetSuppressionListResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCommunicationArmClient(client).GetSuppressionListResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SuppressionListAddressResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SuppressionListAddressResource.CreateResourceIdentifier" /> to create a <see cref="SuppressionListAddressResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationArmClient.GetSuppressionListAddressResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SuppressionListAddressResource"/> object. </returns>
        public static SuppressionListAddressResource GetSuppressionListAddressResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableCommunicationArmClient(client).GetSuppressionListAddressResource(id);
        }

        /// <summary>
        /// Gets a collection of CommunicationServiceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationResourceGroupResource.GetCommunicationServiceResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of CommunicationServiceResources and their operations over a CommunicationServiceResource. </returns>
        public static CommunicationServiceResourceCollection GetCommunicationServiceResources(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableCommunicationResourceGroupResource(resourceGroupResource).GetCommunicationServiceResources();
        }

        /// <summary>
        /// Get the CommunicationService and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationResourceGroupResource.GetCommunicationServiceResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="communicationServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<CommunicationServiceResource>> GetCommunicationServiceResourceAsync(this ResourceGroupResource resourceGroupResource, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableCommunicationResourceGroupResource(resourceGroupResource).GetCommunicationServiceResourceAsync(communicationServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the CommunicationService and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/communicationServices/{communicationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationResourceGroupResource.GetCommunicationServiceResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="communicationServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<CommunicationServiceResource> GetCommunicationServiceResource(this ResourceGroupResource resourceGroupResource, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableCommunicationResourceGroupResource(resourceGroupResource).GetCommunicationServiceResource(communicationServiceName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of EmailServiceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationResourceGroupResource.GetEmailServiceResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of EmailServiceResources and their operations over a EmailServiceResource. </returns>
        public static EmailServiceResourceCollection GetEmailServiceResources(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableCommunicationResourceGroupResource(resourceGroupResource).GetEmailServiceResources();
        }

        /// <summary>
        /// Get the EmailService and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationResourceGroupResource.GetEmailServiceResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="emailServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EmailServiceResource>> GetEmailServiceResourceAsync(this ResourceGroupResource resourceGroupResource, string emailServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableCommunicationResourceGroupResource(resourceGroupResource).GetEmailServiceResourceAsync(emailServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the EmailService and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationResourceGroupResource.GetEmailServiceResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="emailServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<EmailServiceResource> GetEmailServiceResource(this ResourceGroupResource resourceGroupResource, string emailServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableCommunicationResourceGroupResource(resourceGroupResource).GetEmailServiceResource(emailServiceName, cancellationToken);
        }

        /// <summary>
        /// Checks that the CommunicationService name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationSubscriptionResource.CheckCommunicationNameAvailability(CommunicationServiceNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<CommunicationNameAvailabilityResult>> CheckCommunicationNameAvailabilityAsync(this SubscriptionResource subscriptionResource, CommunicationServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableCommunicationSubscriptionResource(subscriptionResource).CheckCommunicationNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the CommunicationService name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationSubscriptionResource.CheckCommunicationNameAvailability(CommunicationServiceNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<CommunicationNameAvailabilityResult> CheckCommunicationNameAvailability(this SubscriptionResource subscriptionResource, CommunicationServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCommunicationSubscriptionResource(subscriptionResource).CheckCommunicationNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/communicationServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationSubscriptionResource.GetCommunicationServiceResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="CommunicationServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<CommunicationServiceResource> GetCommunicationServiceResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCommunicationSubscriptionResource(subscriptionResource).GetCommunicationServiceResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/communicationServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationSubscriptionResource.GetCommunicationServiceResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="CommunicationServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<CommunicationServiceResource> GetCommunicationServiceResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCommunicationSubscriptionResource(subscriptionResource).GetCommunicationServiceResources(cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/emailServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationSubscriptionResource.GetEmailServiceResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="EmailServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EmailServiceResource> GetEmailServiceResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCommunicationSubscriptionResource(subscriptionResource).GetEmailServiceResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/emailServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationSubscriptionResource.GetEmailServiceResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="EmailServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EmailServiceResource> GetEmailServiceResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCommunicationSubscriptionResource(subscriptionResource).GetEmailServiceResources(cancellationToken);
        }

        /// <summary>
        /// Get a list of domains that are fully verified in Exchange Online.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/listVerifiedExchangeOnlineDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListVerifiedExchangeOnlineDomains</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationSubscriptionResource.GetVerifiedExchangeOnlineDomainsEmailServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="string"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<string> GetVerifiedExchangeOnlineDomainsEmailServicesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCommunicationSubscriptionResource(subscriptionResource).GetVerifiedExchangeOnlineDomainsEmailServicesAsync(cancellationToken);
        }

        /// <summary>
        /// Get a list of domains that are fully verified in Exchange Online.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/listVerifiedExchangeOnlineDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListVerifiedExchangeOnlineDomains</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableCommunicationSubscriptionResource.GetVerifiedExchangeOnlineDomainsEmailServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="string"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<string> GetVerifiedExchangeOnlineDomainsEmailServices(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableCommunicationSubscriptionResource(subscriptionResource).GetVerifiedExchangeOnlineDomainsEmailServices(cancellationToken);
        }
    }
}
