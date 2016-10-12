using System;
using System.Collections.Generic;

namespace HD.Station.Data.News
{
    public partial class Queue
    {
        public Queue()
        {
            RunningOrderItem = new HashSet<RunningOrderItem>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Duration { get; set; }
        public Guid RunningOrderId { get; set; }
        public int QueueOrder { get; set; }

        public virtual ICollection<RunningOrderItem> RunningOrderItem { get; set; }
        public virtual RunningOrder RunningOrder { get; set; }
    }
}
