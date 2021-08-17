using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class Teacher
    {
        public Teacher()
        {
            PeriodDetails = new HashSet<PeriodDetail>();
        }

        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string MobileNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<PeriodDetail> PeriodDetails { get; set; }
    }
}
