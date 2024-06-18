using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI_Core.Entities
{
    
    public class Board
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BoardId {  get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DeadLine { get; set; }
        public string? BoardStatus { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public virtual User? CreatedByUser { get; set; }

        public virtual User? UpdatedByUser { get; set; }


    }
}
