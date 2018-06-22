using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdageTracker.Web.Startup))]
namespace AdageTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var res = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Resolutions.GetResolutionsAsync().Result;
            var stat = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Statuses.GetStatusesAsync().Result;
            var version = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Versions.GetVersionsAsync("T3").Result;
            var comp = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Components.GetComponentsAsync("T3").Result;
            var field = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Fields.GetCustomFieldsAsync().Result;
            var issue = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().IssueTypes.GetIssueTypesAsync().Result;
            var prior = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Priorities.GetPrioritiesAsync().Result;
            //var test = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().RestClient.RestSharpClient.
            //var user = new AdageTracker.JIRA.Implement\ations.JIRAClientFactory().GetJiraClient().Users.GetUserAsync("adageuser").Result;
            //var user = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Eve
            ConfigureAuth(app);
        }
    }
}
