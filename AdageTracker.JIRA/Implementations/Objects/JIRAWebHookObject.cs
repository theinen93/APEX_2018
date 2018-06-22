using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdageTracker.JIRA.Implementations.Objects
{
    public partial class JIRAWebHookObject
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("webhookEvent")]
        public string WebhookEvent { get; set; }

        [JsonProperty("issue_event_type_name")]
        public string IssueEventTypeName { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("issue")]
        public Issue Issue { get; set; }
    }

    public partial class Issue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("fields")]
        public Fields Fields { get; set; }
    }

    public partial class Fields
    {
        [JsonProperty("issuetype")]
        public Issuetype Issuetype { get; set; }

        [JsonProperty("timespent")]
        public object Timespent { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("fixVersions")]
        public object[] FixVersions { get; set; }

        [JsonProperty("aggregatetimespent")]
        public object Aggregatetimespent { get; set; }

        [JsonProperty("resolution")]
        public object Resolution { get; set; }

        [JsonProperty("resolutiondate")]
        public object Resolutiondate { get; set; }

        [JsonProperty("workratio")]
        public long Workratio { get; set; }

        [JsonProperty("watches")]
        public Watches Watches { get; set; }

        [JsonProperty("lastViewed")]
        public DateTimeOffset LastViewed { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }


        [JsonProperty("priority")]
        public Priority Priority { get; set; }

        [JsonProperty("labels")]
        public object[] Labels { get; set; }

        [JsonProperty("aggregatetimeoriginalestimate")]
        public object Aggregatetimeoriginalestimate { get; set; }

        [JsonProperty("timeestimate")]
        public object Timeestimate { get; set; }

        [JsonProperty("versions")]
        public object[] Versions { get; set; }

        [JsonProperty("issuelinks")]
        public object[] Issuelinks { get; set; }

        [JsonProperty("assignee")]
        public object Assignee { get; set; }

        [JsonProperty("updated")]
        public DateTimeOffset Updated { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("components")]
        public object[] Components { get; set; }

        [JsonProperty("timeoriginalestimate")]
        public object Timeoriginalestimate { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("attachment")]
        public object[] Attachment { get; set; }

        [JsonProperty("aggregatetimeestimate")]
        public object Aggregatetimeestimate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("creator")]
        public User Creator { get; set; }

        [JsonProperty("subtasks")]
        public object[] Subtasks { get; set; }

        [JsonProperty("reporter")]
        public User Reporter { get; set; }

        [JsonProperty("aggregateprogress")]
        public Progress Aggregateprogress { get; set; }

        [JsonProperty("environment")]
        public object Environment { get; set; }

        [JsonProperty("duedate")]
        public object Duedate { get; set; }

        [JsonProperty("progress")]
        public Progress Progress { get; set; }

        [JsonProperty("votes")]
        public Votes Votes { get; set; }
    }

    public partial class Progress
    {
        [JsonProperty("progress")]
        public long ProgressProgress { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

    public partial class User
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("avatarUrls")]
        public Dictionary<string, string> AvatarUrls { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public partial class Issuetype
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subtask")]
        public bool Subtask { get; set; }

        [JsonProperty("avatarId")]
        public long AvatarId { get; set; }
    }

    public partial class Priority
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class Project
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectTypeKey")]
        public string ProjectTypeKey { get; set; }

        [JsonProperty("avatarUrls")]
        public Dictionary<string, string> AvatarUrls { get; set; }

        [JsonProperty("projectCategory")]
        public Priority ProjectCategory { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("statusCategory")]
        public StatusCategory StatusCategory { get; set; }
    }

    public partial class StatusCategory
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("colorName")]
        public string ColorName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Timetracking
    {
    }

    public partial class Votes
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("votes")]
        public long VotesVotes { get; set; }

        [JsonProperty("hasVoted")]
        public bool HasVoted { get; set; }
    }

    public partial class Watches
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("watchCount")]
        public long WatchCount { get; set; }

        [JsonProperty("isWatching")]
        public bool IsWatching { get; set; }
    }

    public partial class JIRAWebHookObject
    {
        public static JIRAWebHookObject FromJson(string json) => JsonConvert.DeserializeObject<JIRAWebHookObject>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this JIRAWebHookObject self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}