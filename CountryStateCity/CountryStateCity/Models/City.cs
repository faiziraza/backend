using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CountryStateCity.Models
{
    public class City
    {
        [Key]
        public int ctId { get; set; }
        public string CityName { get; set; }
        [ForeignKey("State")]
        public int stId { get; set; }
        public virtual State State { get; set; }
    }
}
