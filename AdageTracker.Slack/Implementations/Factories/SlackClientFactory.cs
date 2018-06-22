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
        const string AUTH_TOKEN = "xoxp-3311335400-198618643633-385993138033-69baa2cec72638e37174844d2d12fd39";
        private SlackClient slackClient;
        public SlackClientFactory()
        {
            slackClient = new SlackClient(AUTH_TOKEN);
        }

        public void PostMessageToAdageTracker(string text, string botName)
        {
            slackClient.PostMessage(null, "#adage-tracker", text, botName);
        }

        public void PostMessage(string channel, string text, string botName)
        {
            slackClient.PostMessage(null, channel, text, botName);
        }
    }
}
