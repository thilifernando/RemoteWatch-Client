using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RemoteWatch
{
    public class Project
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool isActive { get; set; }

        [JsonProperty(PropertyName = "projectName")]
        public String ProjectName { get; set; }
        [JsonProperty(PropertyName = "projectId")]
        public String ProjectId { get; set; }

        [JsonProperty(PropertyName = "userRole")]
        public string userRole { get; set; }

        [JsonProperty(PropertyName = "isEligible")]
        public bool isEligible { get; set; }

        [JsonProperty(PropertyName = "allocatedTimestamp")]
        public long allocatedTimestamp { get; set; }

        [JsonProperty(PropertyName = "deallocatedTimestamp")]
        public long deallocatedTimestamp { get; set; }

        [JsonProperty(PropertyName = "eligibilityEnabledTimestamp")]
        public long eligibilityEnabledTimestamp { get; set; }

        [JsonProperty(PropertyName = "eligibilityRemovedTimestamp")]
        public long eligibilityRemovedTimestamp { get; set; }

        [JsonProperty(PropertyName = "isExemptionExplicit")]
        public bool isExemptionExplicit { get; set; }

        [JsonProperty(PropertyName = "exemptionReason")]
        public String exemptionReason { get; set; }

        [JsonProperty(PropertyName = "isDeprecated")]
        public bool IsDeprecated { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class User
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public bool isActive { get; set; }

        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "employee_id")]
        public string employee_id { get; set; }

        [JsonIgnore]
        public String UserToken { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }

    public class ActivityType
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonIgnore]
        public bool isActive { get; set; }

        [JsonProperty(PropertyName = "activityTypeName")]
        public string Activity_type { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }


    }

    public class MeetingEvent
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public string Subject { get; set; }

        public long StartTime { get; set; }

        public long EndTime { get; set; }

        public User User { get; set; }

        public string Status { get; set; }

        public bool isCancelled { get; set; }

        public MeetingEvent(string Key, string Subject, long StartTime, long EndTime, string Status, bool isCancelled)
        {
            this.Key = Key;
            this.Subject = Subject;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.User = User;
            this.Status = Status;
            this.isCancelled = isCancelled;
        }


        public MeetingEvent()
        {

        }

    }

    public class Configuration
    {
        public int Id { get; set; }

        public List<ConfigurationEntry> Configurations { get; set; }


        public Configuration()
        {
            if (Configurations == null)
            {
                Configurations = new List<ConfigurationEntry>();
            }
        }
    }

    public class ConfigurationEntry
    {
        public int Id { get; set; }

        public String Key { get; set; }

        public String Value { get; set; }

        public ConfigurationEntry(String key, String value)
        {
            this.Key = key;
            this.Value = value;
        }
    }

    public class DailyEffort
    {
        public DateTime Date { get; set; }

        public Project Project { get; set; }

        public ActivityType Type { get; set; }

        public float Duration { get; set; }

        public int taskId { get; set; }

        public float submittedDuration { get; set; }

        public string taskName { get; set; }

        public DailyEffort(DateTime date, Project project, ActivityType type, float duration)
        {
            Date = date;
            Project = project;
            Type = type;
            Duration = duration;
        }

        public DailyEffort() { }
    }

    public class TaskWorkTypeMapping
    {

        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        public Project project { get; set; }

        public int taskId { get; set; }

        public string taskName { get; set; }

        public string mappedWorkTypes { get; set; }
    }

    public class Comment
    {

        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        public String comment { get; set; }

        public Project project { get; set; }

        public int taskId { get; set; }

        public int weekNo { get; set; }

        public long Date { get; set; }

    }


}
