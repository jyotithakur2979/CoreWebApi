using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class ReportCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RollNo { get; set; }
        public int? Hindi { get; set; }
        public int? Eng { get; set; }
        public int? Maths { get; set; }
        public int? Phs { get; set; }
        public int? Chy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
