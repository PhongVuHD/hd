using System;
using System.Collections.Generic;

namespace HD.Station.Data.News
{
    public partial class RunningOrder
    {
        public RunningOrder()
        {
            Queue = new HashSet<Queue>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public long? Duration { get; set; }
        public bool IsTemplate { get; set; }
        public virtual ICollection<Queue> Queue { get; set; }
    }
}
