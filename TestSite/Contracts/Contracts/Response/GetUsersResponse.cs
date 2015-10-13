using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Contracts.Response
{
    public class GetUsersResponse
    {
        public int TotalRows { get; set; }
        public Data Data { get; set; }
    }
}
