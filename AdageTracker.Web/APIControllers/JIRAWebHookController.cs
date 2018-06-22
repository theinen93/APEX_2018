using AdageTracker.JIRA.Implementations.Objects;
//using QuickType;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AdageTracker.Web.APIControllers
{
    [RoutePrefix("api/v1/jirawebhook")]
    public class JIRAWebHookController : ApiController
    {
        [AcceptVerbs("GET", "POST")]
        [HttpPost]
        [Route("test")]
        public IHttpActionResult Test([FromBody] object JiraData)
        {
            try
            {
                var url = "https://adagetechnologies.atlassian.net/browse/{0}";
                var JIRAclient = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient();
                var slackClient = new AdageTracker.Slack.Implementations.Factories.SlackClientFactory();

                // Debug
                using (StreamWriter _testData = new StreamWriter("C:/Working/Adage_Tracker/data.txt", true))
                {
                    _testData.WriteLine(JiraData);
                }

                var data = JIRAWebHookObject.FromJson(JiraData.ToString());
                var issue = JIRAclient.Issues.GetIssueAsync(data.Issue.Key).Result;
                var changeLog = JIRAclient.Issues.GetChangeLogsAsync(data.Issue.Key).Result;

                if (changeLog.OrderByDescending(c => c.CreatedDate).FirstOrDefault().Items.Any(i => i.FromValue == "Ready for Adage QA" && i.ToValue == "In Progress"))
                {
                    slackClient.PostMessageToAdageTracker(string.Format("Ticket {0}, failed QA: {1}", data.Issue.Key, string.Format(url, data.Issue.Key)), "FAIL BOT");
                }

                else if (changeLog.OrderByDescending(c => c.CreatedDate).FirstOrDefault().Items.Any(i => i.FromValue == "Ready for Client UAT" && i.ToValue == "In Progress"))
                {
                    slackClient.PostMessageToAdageTracker(string.Format("Ticket {0}, failed UAT: {1}", data.Issue.Key, string.Format(url, data.Issue.Key)), "FAIL BOT");
                }
            }

            catch (Exception ex)
            {
                using (StreamWriter _testData = new StreamWriter("C:/Working/Adage_Tracker/data.txt", true))
                {
                    _testData.WriteLine(ex.Message); // Write the file.
                }
            }

            return Ok("Success");
        }
    }


}


