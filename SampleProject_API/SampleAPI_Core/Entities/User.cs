using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI_Core.Entities
{

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }

        public string UserName { get; set; }
        public string UserEmail {  get; set; }

        public string UserPassword { get; set; }

     



    }
}
