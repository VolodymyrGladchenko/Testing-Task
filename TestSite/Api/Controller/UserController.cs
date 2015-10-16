using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Contracts.Contracts;
using Contracts.Contracts.Request;
using Contracts.Contracts.Response;
using DAL.DA;

namespace Api.Controller
{
    /// <summary>
    ///     Web API controller for Get and Post requests
    /// </summary>
    public class UserController : ApiController
    {
        DataAccess dbProxy = new DataAccess();

        /// <summary>
        ///     Get all users
        /// </summary>
        /// <returns></returns>
        [Route("api/users")]
        public GetUsersResponse Get([FromUri]GetUsersRequest request)
        {
            var usersDb = dbProxy.GetUsers(request.pageNumber, request.pageSize);
            var usersFromPage = PageResolver.GetPage(usersDb, request);
            return new GetUsersResponse {Data = new Data {Users = usersFromPage.ToList() }, TotalRows = usersDb.Count};
        }



        /// <summary>
        /// POST to Save user
        /// </summary>
        /// <param name="value"></param>
        [Route("api/users")]
        public string Post([FromBody] User user)
        {
            try
            {
                dbProxy.SaveOrUpdateUser(user);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "success";
        }

        /// <summary>
        /// Put to Update user
        /// </summary>
        /// <param name="value"></param>
        [Route("api/users")]
        public string Put([FromBody] User user)
        {
            try
            {
                dbProxy.SaveOrUpdateUser(user);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "success";
        }
    }
}