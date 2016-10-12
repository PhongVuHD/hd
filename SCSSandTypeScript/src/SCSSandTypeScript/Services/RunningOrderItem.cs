using System;
using System.Collections.Generic;
using HD.Station.Data.MediaAssets;
namespace HD.Station.Data.News
{
    public partial class RunningOrderItem
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int? StoryOrder { get; set; }
        public long? Duration { get; set; }
        public Guid QueueId { get; set; }
        public Guid? StoryVersion { get; set; }
        public Guid? ContentId { get; set; }

        public virtual Content Content { get; set; }
        public virtual Queue Queue { get; set; }
    }
}
