using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class UserMst
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
