// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{

    /// <summary>
    /// Defines values for PartitionScheme.
    /// </summary>
    public static class PartitionScheme
    {
        /// <summary>
        /// Indicates that the partition is based on string names, and is a
        /// SingletonPartitionScheme object, The value is 0.
        /// </summary>
        public const string Singleton = "Singleton";
        /// <summary>
        /// Indicates that the partition is based on Int64 key ranges, and is a
        /// UniformInt64RangePartitionScheme object. The value is 1.
        /// </summary>
        public const string UniformInt64Range = "UniformInt64Range";
        /// <summary>
        /// Indicates that the partition is based on string names, and is a
        /// NamedPartitionScheme object. The value is 2.
        /// </summary>
        public const string Named = "Named";
    }
}
