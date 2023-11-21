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
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableAppServiceTenantResource : ArmResource
    {
        private ClientDiagnostics _certificateRegistrationProviderClientDiagnostics;
        private CertificateRegistrationProviderRestOperations _certificateRegistrationProviderRestClient;
        private ClientDiagnostics _domainRegistrationProviderClientDiagnostics;
        private DomainRegistrationProviderRestOperations _domainRegistrationProviderRestClient;
        private ClientDiagnostics _providerClientDiagnostics;
        private ProviderRestOperations _providerRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAppServiceTenantResource"/> class for mocking. </summary>
        protected MockableAppServiceTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppServiceTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppServiceTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics CertificateRegistrationProviderClientDiagnostics => _certificateRegistrationProviderClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CertificateRegistrationProviderRestOperations CertificateRegistrationProviderRestClient => _certificateRegistrationProviderRestClient ??= new CertificateRegistrationProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DomainRegistrationProviderClientDiagnostics => _domainRegistrationProviderClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DomainRegistrationProviderRestOperations DomainRegistrationProviderRestClient => _domainRegistrationProviderRestClient ??= new DomainRegistrationProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ProviderClientDiagnostics => _providerClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ProviderRestOperations ProviderRestClient => _providerRestClient ??= new ProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets an object representing a PublishingUserResource along with the instance operations that can be performed on it in the TenantResource. </summary>
        /// <returns> Returns a <see cref="PublishingUserResource"/> object. </returns>
        public virtual PublishingUserResource GetPublishingUser()
        {
            return new PublishingUserResource(Client, Id.AppendProviderResource("Microsoft.Web", "publishingUsers", "web"));
        }

        /// <summary> Gets a collection of AppServiceSourceControlResources in the TenantResource. </summary>
        /// <returns> An object representing collection of AppServiceSourceControlResources and their operations over a AppServiceSourceControlResource. </returns>
        public virtual AppServiceSourceControlCollection GetAppServiceSourceControls()
        {
            return GetCachedClient(client => new AppServiceSourceControlCollection(client, Id));
        }

        /// <summary>
        /// Description for Gets source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppServiceSourceControlResource>> GetAppServiceSourceControlAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            return await GetAppServiceSourceControls().GetAsync(sourceControlType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlType"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppServiceSourceControlResource> GetAppServiceSourceControl(string sourceControlType, CancellationToken cancellationToken = default)
        {
            return GetAppServiceSourceControls().Get(sourceControlType, cancellationToken);
        }

        /// <summary>
        /// Description for Implements Csm operations Api to exposes the list of available Csm Apis under the resource provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CertificateRegistration/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateRegistrationProvider_ListOperations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CsmOperationDescription"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CsmOperationDescription> GetOperationsCertificateRegistrationProvidersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CertificateRegistrationProviderRestClient.CreateListOperationsRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CertificateRegistrationProviderRestClient.CreateListOperationsNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, CsmOperationDescription.DeserializeCsmOperationDescription, CertificateRegistrationProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetOperationsCertificateRegistrationProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Implements Csm operations Api to exposes the list of available Csm Apis under the resource provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CertificateRegistration/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateRegistrationProvider_ListOperations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CsmOperationDescription"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CsmOperationDescription> GetOperationsCertificateRegistrationProviders(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CertificateRegistrationProviderRestClient.CreateListOperationsRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CertificateRegistrationProviderRestClient.CreateListOperationsNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, CsmOperationDescription.DeserializeCsmOperationDescription, CertificateRegistrationProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetOperationsCertificateRegistrationProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Implements Csm operations Api to exposes the list of available Csm Apis under the resource provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DomainRegistration/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainRegistrationProvider_ListOperations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CsmOperationDescription"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CsmOperationDescription> GetOperationsDomainRegistrationProvidersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DomainRegistrationProviderRestClient.CreateListOperationsRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DomainRegistrationProviderRestClient.CreateListOperationsNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, CsmOperationDescription.DeserializeCsmOperationDescription, DomainRegistrationProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetOperationsDomainRegistrationProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Implements Csm operations Api to exposes the list of available Csm Apis under the resource provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DomainRegistration/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainRegistrationProvider_ListOperations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CsmOperationDescription"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CsmOperationDescription> GetOperationsDomainRegistrationProviders(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DomainRegistrationProviderRestClient.CreateListOperationsRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DomainRegistrationProviderRestClient.CreateListOperationsNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, CsmOperationDescription.DeserializeCsmOperationDescription, DomainRegistrationProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetOperationsDomainRegistrationProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available application frameworks and their versions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/availableStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetAvailableStacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osTypeSelected"> The ProviderOSTypeSelected to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationStackResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationStackResource> GetAvailableStacksProvidersAsync(ProviderOSTypeSelected? osTypeSelected = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetAvailableStacksRequest(osTypeSelected);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetAvailableStacksNextPageRequest(nextLink, osTypeSelected);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ApplicationStackResource.DeserializeApplicationStackResource, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetAvailableStacksProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available application frameworks and their versions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/availableStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetAvailableStacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osTypeSelected"> The ProviderOSTypeSelected to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationStackResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationStackResource> GetAvailableStacksProviders(ProviderOSTypeSelected? osTypeSelected = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetAvailableStacksRequest(osTypeSelected);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetAvailableStacksNextPageRequest(nextLink, osTypeSelected);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ApplicationStackResource.DeserializeApplicationStackResource, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetAvailableStacksProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available Function app frameworks and their versions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/functionAppStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetFunctionAppStacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackOSType"> Stack OS Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FunctionAppStack"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FunctionAppStack> GetFunctionAppStacksProvidersAsync(ProviderStackOSType? stackOSType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetFunctionAppStacksRequest(stackOSType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetFunctionAppStacksNextPageRequest(nextLink, stackOSType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, FunctionAppStack.DeserializeFunctionAppStack, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetFunctionAppStacksProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available Function app frameworks and their versions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/functionAppStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetFunctionAppStacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackOSType"> Stack OS Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FunctionAppStack"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FunctionAppStack> GetFunctionAppStacksProviders(ProviderStackOSType? stackOSType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetFunctionAppStacksRequest(stackOSType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetFunctionAppStacksNextPageRequest(nextLink, stackOSType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, FunctionAppStack.DeserializeFunctionAppStack, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetFunctionAppStacksProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available Function app frameworks and their versions for location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/locations/{location}/functionAppStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetFunctionAppStacksForLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Function App stack location. </param>
        /// <param name="stackOSType"> Stack OS Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FunctionAppStack"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FunctionAppStack> GetFunctionAppStacksForLocationProvidersAsync(AzureLocation location, ProviderStackOSType? stackOSType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetFunctionAppStacksForLocationRequest(location, stackOSType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetFunctionAppStacksForLocationNextPageRequest(nextLink, location, stackOSType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, FunctionAppStack.DeserializeFunctionAppStack, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetFunctionAppStacksForLocationProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available Function app frameworks and their versions for location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/locations/{location}/functionAppStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetFunctionAppStacksForLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Function App stack location. </param>
        /// <param name="stackOSType"> Stack OS Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FunctionAppStack"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FunctionAppStack> GetFunctionAppStacksForLocationProviders(AzureLocation location, ProviderStackOSType? stackOSType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetFunctionAppStacksForLocationRequest(location, stackOSType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetFunctionAppStacksForLocationNextPageRequest(nextLink, location, stackOSType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, FunctionAppStack.DeserializeFunctionAppStack, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetFunctionAppStacksForLocationProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available Web app frameworks and their versions for location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/locations/{location}/webAppStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetWebAppStacksForLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Web App stack location. </param>
        /// <param name="stackOSType"> Stack OS Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebAppStack"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebAppStack> GetWebAppStacksByLocationAsync(AzureLocation location, ProviderStackOSType? stackOSType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetWebAppStacksForLocationRequest(location, stackOSType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetWebAppStacksForLocationNextPageRequest(nextLink, location, stackOSType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, WebAppStack.DeserializeWebAppStack, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetWebAppStacksByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available Web app frameworks and their versions for location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/locations/{location}/webAppStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetWebAppStacksForLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Web App stack location. </param>
        /// <param name="stackOSType"> Stack OS Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebAppStack"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebAppStack> GetWebAppStacksByLocation(AzureLocation location, ProviderStackOSType? stackOSType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetWebAppStacksForLocationRequest(location, stackOSType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetWebAppStacksForLocationNextPageRequest(nextLink, location, stackOSType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, WebAppStack.DeserializeWebAppStack, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetWebAppStacksByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets all available operations for the Microsoft.Web resource provider. Also exposes resource metric definitions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_ListOperations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CsmOperationDescription"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CsmOperationDescription> GetOperationsProvidersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateListOperationsRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateListOperationsNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, CsmOperationDescription.DeserializeCsmOperationDescription, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetOperationsProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets all available operations for the Microsoft.Web resource provider. Also exposes resource metric definitions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_ListOperations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CsmOperationDescription"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CsmOperationDescription> GetOperationsProviders(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateListOperationsRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateListOperationsNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, CsmOperationDescription.DeserializeCsmOperationDescription, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetOperationsProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available Web app frameworks and their versions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/webAppStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetWebAppStacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackOSType"> Stack OS Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebAppStack"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebAppStack> GetWebAppStacksProvidersAsync(ProviderStackOSType? stackOSType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetWebAppStacksRequest(stackOSType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetWebAppStacksNextPageRequest(nextLink, stackOSType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, WebAppStack.DeserializeWebAppStack, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetWebAppStacksProviders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available Web app frameworks and their versions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/webAppStacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Provider_GetWebAppStacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackOSType"> Stack OS Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebAppStack"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebAppStack> GetWebAppStacksProviders(ProviderStackOSType? stackOSType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProviderRestClient.CreateGetWebAppStacksRequest(stackOSType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProviderRestClient.CreateGetWebAppStacksNextPageRequest(nextLink, stackOSType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, WebAppStack.DeserializeWebAppStack, ProviderClientDiagnostics, Pipeline, "MockableAppServiceTenantResource.GetWebAppStacksProviders", "value", "nextLink", cancellationToken);
        }
    }
}
