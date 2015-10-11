using System.Collections.Generic;
using System.Web.Http;

namespace Api.Controller
{
    /// <summary>
    /// Web API controller for Get and Post requests 
    /// </summary>
    public class UserController : ApiController
    {
       
        [Route("api/users")]
        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }

        [Route("api/users/{userId}}")]
        public string Get(int userId)
        {
            return "value";
        }

        [Route("api/users}")]
        public void Post([FromBody] string value)
        {
        }

    }
}