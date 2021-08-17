using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class Blog
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Status { get; set; }
    }
}
