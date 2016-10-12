using System;
using System.Collections.Generic;

namespace HD.Station.Data.News
{
    public partial class RunningOrderTemplate
    {
        public RunningOrderTemplate()
        {
            TemplateItem = new HashSet<TemplateItem>();
        }

        public Guid TemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public long Duration { get; set; }

        public virtual ICollection<TemplateItem> TemplateItem { get; set; }
    }
}
