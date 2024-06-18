using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI_Core.Entities
{
    public class Weather
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WeatherId  { get; set; }
        public virtual City City { get; set; }

        public decimal Temprature { get; set; }

        public string TempratureUnit { get; set; }

        public DateTime DateTime { get; set; }
    }
}
