using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class EmployeDatum
    {
        public int Id { get; set; }
        public string Employename { get; set; }
        public string Companyname { get; set; }
        public string Mobileno { get; set; }
        public string Emailid { get; set; }
    }
}
