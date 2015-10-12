using System.Collections.Generic;
using System.Web.Http;

namespace Api.Controller
{
    /// <summary>
    /// Web API controller for Get and Post requests 
    /// </summary>
    public class UserController : ApiController
    {
       
        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [Route("api/users")]
        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }

        /// <summary>
        /// Get with input parameter to get user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [Route("api/users/{userId}")]
        public string Get(int userId)
        {
            return "value";
        }

        /// <summary>
        /// POST to Save new user
        /// </summary>
        /// <param name="value"></param>
        [Route("api/users")]
        public void Post([FromBody] string value)
        {
        }

    }
}