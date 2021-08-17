using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class TeacherRecord
    {
        public int Id { get; set; }
        public string Teachername { get; set; }
        public int? Class { get; set; }
        public string Subject { get; set; }
        public string Mobileno { get; set; }
        public DateTime? Createdate { get; set; }
        public bool? Status { get; set; }
    }
}
