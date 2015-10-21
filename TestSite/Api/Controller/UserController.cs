using System;
using System.Linq;
using System.Web.Http;
using Contracts.Contracts;
using Contracts.Contracts.Request;
using Contracts.Contracts.Response;
using DAL.DA;

namespace Api.Controller
{

    public class UserController : ApiController{
        private readonly IDataAccess dbProxy;

        public UserController(IDataAccess dbProxy)
        {
            this.dbProxy = dbProxy;
        }

        [Route("api/users")]
        public GetUsersResponse Get([FromUri] GetUsersRequest request)
        {
            var usersDb = dbProxy.GetUsers(request.pageNumber, request.pageSize);
            var usersFromPage = PageResolver.GetPage(usersDb, request);
            return new GetUsersResponse {Data = new Data {Users = usersFromPage.ToList()}, TotalRows = usersDb.Count};
        }


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