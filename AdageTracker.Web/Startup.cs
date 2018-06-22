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
            var version = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Versions.GetVersionsAsync("ATR").Result;
            var comp = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Components.GetComponentsAsync("ATR").Result;
            var field = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Fields.GetCustomFieldsAsync().Result;
            var issue = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().IssueTypes.GetIssueTypesAsync().Result;
            var prior = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().Priorities.GetPrioritiesAsync().Result;
            //var test = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient().RestClient.RestSharpClient.
            ConfigureAuth(app);


            var test = new AdageTracker.Slack.Implementations.Factories.SlackClientFactory();
            test.AuthenticateSlack();
        }
    }
}
