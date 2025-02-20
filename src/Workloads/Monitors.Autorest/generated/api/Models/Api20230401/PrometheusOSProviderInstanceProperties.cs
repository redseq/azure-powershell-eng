// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Extensions;

    /// <summary>Gets or sets the PrometheusOS provider properties.</summary>
    public partial class PrometheusOSProviderInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IPrometheusOSProviderInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IPrometheusOSProviderInstancePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificProperties __providerSpecificProperties = new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.ProviderSpecificProperties();

        /// <summary>Backing field for <see cref="PrometheusUrl" /> property.</summary>
        private string _prometheusUrl;

        /// <summary>URL of the Node Exporter endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string PrometheusUrl { get => this._prometheusUrl; set => this._prometheusUrl = value; }

        /// <summary>The provider type. For example, the value can be SapHana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Inherited)]
        public string ProviderType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificPropertiesInternal)__providerSpecificProperties).ProviderType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificPropertiesInternal)__providerSpecificProperties).ProviderType = value ; }

        /// <summary>Backing field for <see cref="SapSid" /> property.</summary>
        private string _sapSid;

        /// <summary>Gets or sets the SAP System Identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SapSid { get => this._sapSid; set => this._sapSid = value; }

        /// <summary>Backing field for <see cref="SslCertificateUri" /> property.</summary>
        private string _sslCertificateUri;

        /// <summary>Gets or sets the blob URI to SSL certificate for the prometheus node exporter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SslCertificateUri { get => this._sslCertificateUri; set => this._sslCertificateUri = value; }

        /// <summary>Backing field for <see cref="SslPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference? _sslPreference;

        /// <summary>Gets or sets certificate preference if secure communication is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference? SslPreference { get => this._sslPreference; set => this._sslPreference = value; }

        /// <summary>Creates an new <see cref="PrometheusOSProviderInstanceProperties" /> instance.</summary>
        public PrometheusOSProviderInstanceProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__providerSpecificProperties), __providerSpecificProperties);
            await eventListener.AssertObjectIsValid(nameof(__providerSpecificProperties), __providerSpecificProperties);
        }
    }
    /// Gets or sets the PrometheusOS provider properties.
    public partial interface IPrometheusOSProviderInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificProperties
    {
        /// <summary>URL of the Node Exporter endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL of the Node Exporter endpoint",
        SerializedName = @"prometheusUrl",
        PossibleTypes = new [] { typeof(string) })]
        string PrometheusUrl { get; set; }
        /// <summary>Gets or sets the SAP System Identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the SAP System Identifier",
        SerializedName = @"sapSid",
        PossibleTypes = new [] { typeof(string) })]
        string SapSid { get; set; }
        /// <summary>Gets or sets the blob URI to SSL certificate for the prometheus node exporter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the blob URI to SSL certificate for the prometheus node exporter.",
        SerializedName = @"sslCertificateUri",
        PossibleTypes = new [] { typeof(string) })]
        string SslCertificateUri { get; set; }
        /// <summary>Gets or sets certificate preference if secure communication is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets certificate preference if secure communication is enabled.",
        SerializedName = @"sslPreference",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference? SslPreference { get; set; }

    }
    /// Gets or sets the PrometheusOS provider properties.
    internal partial interface IPrometheusOSProviderInstancePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificPropertiesInternal
    {
        /// <summary>URL of the Node Exporter endpoint</summary>
        string PrometheusUrl { get; set; }
        /// <summary>Gets or sets the SAP System Identifier</summary>
        string SapSid { get; set; }
        /// <summary>Gets or sets the blob URI to SSL certificate for the prometheus node exporter.</summary>
        string SslCertificateUri { get; set; }
        /// <summary>Gets or sets certificate preference if secure communication is enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference? SslPreference { get; set; }

    }
}