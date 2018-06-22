using Atlassian.Jira;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdageTracker.JIRA.Interfaces
{
    public interface IJIRAClientFactory
    {
        Jira GetJiraClient();
    }
}
