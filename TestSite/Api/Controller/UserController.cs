using System.Collections.Generic;
using System.Web.Http;
using Contracts.Contracts;
using Contracts.Contracts.Request;
using Contracts.Contracts.Response;

namespace Api.Controller
{
    /// <summary>
    ///     Web API controller for Get and Post requests
    /// </summary>
    public class UserController : ApiController
    {
        /// <summary>
        ///     Get all users
        /// </summary>
        /// <returns></returns>
        [Route("api/users")]
        public GetUsersResponse Get(GetUsersRequest request)
        {
            var user = new User
            {
                Email = "mail.ru",
                Id = 1,
                LastName = "Last",
                Name = "Names",
                Phones =
                    new List<string>
                    {"923-32-23", "423-32-23"}
            };

            var user1 = new User
            {
                Email = "mail.ru",
                Id = 2,
                LastName = "Last",
                Name = "Names",
                Phones =
                    new List<string>
                    {"923-32-23", "423-32-23"}
            };


            var users = new List<User>();
            users.Add(user);
            users.Add(user1);

            return new GetUsersResponse {Data = new Data {Users = users}, TotalRows = users.Count};
        }


        [Route("api/users/{userId}")]
        public string Get()
        {
            return "value";
        }

        /// <summary>
        ///     POST to Save new user
        /// </summary>
        /// <param name="value"></param>
        [Route("api/users")]
        public void Post([FromBody] string value)
        {
        }
    }
}