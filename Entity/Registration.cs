using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Emailid { get; set; }
        public string Password { get; set; }
        public string Mobileno { get; set; }
        public DateTime? Createdate { get; set; }
        public bool? Status { get; set; }
    }
}
