using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Contracts;
using Contracts.Contracts.Request;

namespace Api.Controller
{
    public class PageResolver
    {
        public static IEnumerable<User> GetPage(IEnumerable<User> input, GetUsersRequest request)
        {
            if (!request.pageNumber.HasValue || !request.pageSize.HasValue) return input;
            var pageSize = request.pageSize.Value;
            var currentPage = request.pageNumber.Value - 1;
            input = input.Skip(pageSize * currentPage).Take(pageSize);
            return input;
        }

    }
}
