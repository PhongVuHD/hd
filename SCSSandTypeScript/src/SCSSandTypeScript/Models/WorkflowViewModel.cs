using HD.Station.Data.MediaAssets;
using HD.Station.Data.Workflows;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HD.Station.Models
{
    public class WorkflowViewModel
    {
        public Guid Id { get; set; }

        public int Version { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(2048)]
        public string Description { get; set; }

        public bool Disabled { get; set; }

        [Timestamp]
        public byte[] Revision { get; set; }

        public string Data { get; set; }


        public static WorkflowViewModel FromModel(Workflow workflow)
        {
            return new WorkflowViewModel
            {
                Id = workflow.Id,
                Name = workflow.Name,
                Description = workflow.Description,
                Disabled = workflow.Disabled,
                Revision = workflow.Revision,
                Data = workflow.Data,
                Version = workflow.Version
            };
        }

        public Workflow ToModel()
        {
            Workflow workflow = new Workflow
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                Disabled = this.Disabled,
                Data = this.Data,
                Revision = this.Revision,
                Version = this.Version
            };

            return workflow;
        }
        
    }
}