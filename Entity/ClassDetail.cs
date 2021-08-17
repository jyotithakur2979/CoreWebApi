using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class ClassDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rollno { get; set; }
        public string Subject { get; set; }
        public int? Number { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Status { get; set; }
    }
}
