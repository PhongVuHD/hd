using System;
using System.Collections.Generic;
using HD.Station.Data.MediaAssets;
namespace HD.Station.Data.News
{
    public partial class Story: IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public Guid ContentId { get; set; }
        public string StoryScript { get; set; }
        public string Version { get; set; }
        public string Comment { get; set; }

        public virtual Content Content { get; set; }
    }
}
