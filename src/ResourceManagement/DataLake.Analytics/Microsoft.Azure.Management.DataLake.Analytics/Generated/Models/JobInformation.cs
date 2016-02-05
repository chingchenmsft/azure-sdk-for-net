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
    /// The common Data Lake Analytics job information properties.
    /// </summary>
    public partial class JobInformation
    {
        /// <summary>
        /// Initializes a new instance of the JobInformation class.
        /// </summary>
        public JobInformation() { }

        /// <summary>
        /// Initializes a new instance of the JobInformation class.
        /// </summary>
        public JobInformation(string jobId, string name, JobType? type, JobProperties properties, string submitter = default(string), IList<JobErrorDetails> errorMessage = default(IList<JobErrorDetails>), int? degreeOfParallelism = default(int?), int? priority = default(int?), DateTime? submitTime = default(DateTime?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), JobState? state = default(JobState?), JobResult? result = default(JobResult?), IList<JobStateAuditRecord> stateAuditRecords = default(IList<JobStateAuditRecord>))
        {
            JobId = jobId;
            Name = name;
            Type = type;
            Submitter = submitter;
            ErrorMessage = errorMessage;
            DegreeOfParallelism = degreeOfParallelism;
            Priority = priority;
            SubmitTime = submitTime;
            StartTime = startTime;
            EndTime = endTime;
            State = state;
            Result = result;
            StateAuditRecords = stateAuditRecords;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the job's unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the job.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the job type of the current job (i.e. Hive or U-SQL).
        /// Possible values for this property include: 'USql', 'Hive'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public JobType? Type { get; set; }

        /// <summary>
        /// Gets or sets the user or account that submitted the job.
        /// </summary>
        [JsonProperty(PropertyName = "submitter")]
        public string Submitter { get; set; }

        /// <summary>
        /// Gets or sets the error message details for the job, if it failed.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public IList<JobErrorDetails> ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the degree of parallelism used for this job. This
        /// must have a minimum value of 2
        /// </summary>
        [JsonProperty(PropertyName = "degreeOfParallelism")]
        public int? DegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets or sets the priority value for the current job which must be
        /// greater than 1.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the time the job was submitted to the service.
        /// </summary>
        [JsonProperty(PropertyName = "submitTime")]
        public DateTime? SubmitTime { get; set; }

        /// <summary>
        /// Gets or sets the start time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the completion time of the job
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets a more detailed state of the job than the result.
        /// Especially used for intermediate states and errors. Possible
        /// values for this property include: 'Accepted', 'Compiling',
        /// 'Ended', 'New', 'Queued', 'Running', 'Scheduling', 'Starting',
        /// 'Paused', 'WaitingForCapacity'.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public JobState? State { get; set; }

        /// <summary>
        /// Gets or sets the result of job execution or the current result of
        /// the running job. Possible values for this property include:
        /// 'None', 'Succeeded', 'Cancelled', 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public JobResult? Result { get; set; }

        /// <summary>
        /// Gets or sets the job state audit records, indicating when various
        /// operations have been performed on this job.
        /// </summary>
        [JsonProperty(PropertyName = "stateAuditRecords")]
        public IList<JobStateAuditRecord> StateAuditRecords { get; set; }

        /// <summary>
        /// Gets or sets the job specific properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public JobProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (JobId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JobId");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
