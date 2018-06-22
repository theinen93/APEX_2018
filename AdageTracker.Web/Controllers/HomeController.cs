using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdageTracker.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Submit()
        {
            var client = new AdageTracker.JIRA.Implementations.JIRAClientFactory().GetJiraClient();
            var issue = client.Issues.GetIssueAsync("ATR-73").Result;
            var actions = client.Issues.GetActionsAsync("ATR-73").Result;
            issue.WorkflowTransitionAsync(actions.FirstOrDefault().Name).ConfigureAwait(false);
            issue.SaveChanges();
            var test = new AdageTracker.Slack.Implementations.Factories.SlackClientFactory();
            test.AuthenticateSlack();
            return RedirectToAction("Index");
        }
    }
}