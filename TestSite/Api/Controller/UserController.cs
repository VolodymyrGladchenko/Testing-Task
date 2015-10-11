using System.Collections.Generic;
using System.Web.Http;

namespace Api.Controller
{
    public class UserController : ApiController
    {
        [Route("api/users")]
        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }

        [Route("api/users/{userId}")]
        public string Get(int userId)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}