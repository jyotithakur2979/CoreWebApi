using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Requests
{
    public class UserRequest
    {
        public string MobileNo { get; set; }
        public string UserName { get; set; }
        public string emailId { get; set; }
        public string pwd { get; set; }
       
    }
}
