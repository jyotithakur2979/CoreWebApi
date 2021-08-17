using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobileno { get; set; }
        public string City { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
