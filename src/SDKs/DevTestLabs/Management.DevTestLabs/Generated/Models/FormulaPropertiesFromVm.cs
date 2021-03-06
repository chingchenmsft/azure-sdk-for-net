// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Information about a VM from which a formula is to be created.
    /// </summary>
    public partial class FormulaPropertiesFromVm
    {
        /// <summary>
        /// Initializes a new instance of the FormulaPropertiesFromVm class.
        /// </summary>
        public FormulaPropertiesFromVm() { }

        /// <summary>
        /// Initializes a new instance of the FormulaPropertiesFromVm class.
        /// </summary>
        public FormulaPropertiesFromVm(string labVmId = default(string))
        {
            LabVmId = labVmId;
        }

        /// <summary>
        /// The identifier of the VM from which a formula is to be created.
        /// </summary>
        [JsonProperty(PropertyName = "labVmId")]
        public string LabVmId { get; set; }

    }
}
