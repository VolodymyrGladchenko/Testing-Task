using System.Collections.Generic;
using System.Web.Http;

namespace Api.Controller
{
    public class UserController : ApiController
    {
        [Route("api/users/{userId}")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}