using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station.Data
{
    public class SystemMenu : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(2048)]
        public string Description { get; set; }

        public Guid? ParentId { get; set; }

        public string AreaName { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public bool Disabled { get; set; }

        public bool DisplayOrder { get; set; }
    }
}