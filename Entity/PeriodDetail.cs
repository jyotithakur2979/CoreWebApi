using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class PeriodDetail
    {
        public int Id { get; set; }
        public DateTime PeriodDate { get; set; }
        public int PeriodSlot { get; set; }
        public string PeriodForClass { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
