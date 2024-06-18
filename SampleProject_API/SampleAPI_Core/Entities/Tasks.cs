using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI_Core.Entities
{
    public class Tasks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DeadLine { get; set; }
        public string? TaskStatus { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public virtual User? CreatedByUser { get; set; }

        public virtual User? UpdatedByUser { get; }

        public virtual Board? Board { get; set; }

        
    }
}
