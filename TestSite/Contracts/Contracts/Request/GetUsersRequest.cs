﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Contracts.Request
{
    
    public class GetUsersRequest
    {
        public int? pageSize { get; set; }

        public int? pageNumber { get; set; }

        public string sort { get; set; }

        public string filter { get; set; }
    }
}
