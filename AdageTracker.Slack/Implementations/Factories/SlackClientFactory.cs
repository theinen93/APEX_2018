using SlackAPI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdageTracker.Slack.Implementations.Factories
{
    public class SlackClientFactory
    {
        private string authToken;
        private SlackClient slackClient;
        public void AuthenticateSlack()
        {
            authToken = "xoxp-3311335400-198618643633-385993138033-69baa2cec72638e37174844d2d12fd39";

            slackClient = new SlackClient(authToken);
            slackClient.PostMessage(null, "#adage-tracker", "Letsssss goooooooo", "Jo the Robot");
        }
    }
}
