using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI_Core.Entities
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set;  }

        public string Name { get; set; }

        public string CityCode { get; set; }

        public string State { get; set; }
        public string Country { get; set; }

    }
}
