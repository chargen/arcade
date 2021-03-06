// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class WorkItemAggregateSummary
    {
        /// <summary>
        /// Initializes a new instance of the WorkItemAggregateSummary class.
        /// </summary>
        public WorkItemAggregateSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkItemAggregateSummary class.
        /// </summary>
        public WorkItemAggregateSummary(int? jobId = default(int?), int? workItemId = default(int?), string machineName = default(string), string job = default(string), string name = default(string), System.Guid? guid = default(System.Guid?), System.DateTimeOffset? queueTime = default(System.DateTimeOffset?), System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? finishedTime = default(System.DateTimeOffset?), int? exitCode = default(int?), string consoleOutputUri = default(string), IList<WorkItemLog> logs = default(IList<WorkItemLog>), IList<WorkItemError> errors = default(IList<WorkItemError>), IList<WorkItemError> warnings = default(IList<WorkItemError>), IList<UnknownWorkItemEvent> otherEvents = default(IList<UnknownWorkItemEvent>), bool? passed = default(bool?), int? attempt = default(int?), string state = default(string), IDictionary<string, string> key = default(IDictionary<string, string>))
        {
            JobId = jobId;
            WorkItemId = workItemId;
            MachineName = machineName;
            Job = job;
            Name = name;
            Guid = guid;
            QueueTime = queueTime;
            StartTime = startTime;
            FinishedTime = finishedTime;
            ExitCode = exitCode;
            ConsoleOutputUri = consoleOutputUri;
            Logs = logs;
            Errors = errors;
            Warnings = warnings;
            OtherEvents = otherEvents;
            Passed = passed;
            Attempt = attempt;
            State = state;
            Key = key;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JobId")]
        public int? JobId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WorkItemId")]
        public int? WorkItemId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MachineName")]
        public string MachineName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Job")]
        public string Job { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Guid")]
        public System.Guid? Guid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueTime")]
        public System.DateTimeOffset? QueueTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartTime")]
        public System.DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FinishedTime")]
        public System.DateTimeOffset? FinishedTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConsoleOutputUri")]
        public string ConsoleOutputUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Logs")]
        public IList<WorkItemLog> Logs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Errors")]
        public IList<WorkItemError> Errors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Warnings")]
        public IList<WorkItemError> Warnings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OtherEvents")]
        public IList<UnknownWorkItemEvent> OtherEvents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Passed")]
        public bool? Passed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Attempt")]
        public int? Attempt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public IDictionary<string, string> Key { get; set; }

    }
}
