// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    [JsonObject("Hive")]
    public partial class HiveProperties : JobProperties
    {
        /// <summary>
        /// Initializes a new instance of the HiveProperties class.
        /// </summary>
        public HiveProperties() { }

        /// <summary>
        /// Initializes a new instance of the HiveProperties class.
        /// </summary>
        public HiveProperties(string script, string runtimeVersion = default(string), IList<HiveJobStatementInfo> statementInfo = default(IList<HiveJobStatementInfo>), string logsLocation = default(string), string warehouseLocation = default(string), int? statementCount = default(int?), int? executedStatementCount = default(int?))
            : base(script, runtimeVersion)
        {
            StatementInfo = statementInfo;
            LogsLocation = logsLocation;
            WarehouseLocation = warehouseLocation;
            StatementCount = statementCount;
            ExecutedStatementCount = executedStatementCount;
        }

        /// <summary>
        /// Gets or sets the statement information for each statement in the
        /// script
        /// </summary>
        [JsonProperty(PropertyName = "statementInfo")]
        public IList<HiveJobStatementInfo> StatementInfo { get; set; }

        /// <summary>
        /// Gets or sets the Hive logs location
        /// </summary>
        [JsonProperty(PropertyName = "logsLocation")]
        public string LogsLocation { get; set; }

        /// <summary>
        /// Gets or sets the runtime version of the U-SQL engine to use
        /// </summary>
        [JsonProperty(PropertyName = "warehouseLocation")]
        public string WarehouseLocation { get; set; }

        /// <summary>
        /// Gets or sets the number of statements that will be run based on
        /// the script
        /// </summary>
        [JsonProperty(PropertyName = "statementCount")]
        public int? StatementCount { get; set; }

        /// <summary>
        /// Gets or sets the number of statements that have been run based on
        /// the script
        /// </summary>
        [JsonProperty(PropertyName = "executedStatementCount")]
        public int? ExecutedStatementCount { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
