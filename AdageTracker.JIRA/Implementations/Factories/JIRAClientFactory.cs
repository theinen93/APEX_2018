using AdageTracker.JIRA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atlassian.Jira;

namespace AdageTracker.JIRA.Implementations
{
    public class JIRAClientFactory : IJIRAClientFactory
    {
        public Jira GetJiraClient()
        {
            return Jira.CreateRestClient("https://adagetechnologies.atlassian.net", "theinen@adagetechnologies.com", "football24");
        }
    }
}
