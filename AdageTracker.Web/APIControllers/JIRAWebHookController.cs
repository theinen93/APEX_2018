using System;
using System.Collections.Generic;
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
        public IHttpActionResult Test()
        {

            return Ok("Success");
        }
    }
}