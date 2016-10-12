using System;
using System.Collections.Generic;

namespace HD.Station.Data.News
{
    public partial class TemplateItem
    {
        public Guid TemplateItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? Duration { get; set; }
        public Guid TemplateId { get; set; }
        public int SortOrder { get; set; }

        public virtual RunningOrderTemplate Template { get; set; }
    }
}
