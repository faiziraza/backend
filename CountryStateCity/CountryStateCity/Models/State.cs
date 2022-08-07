using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CountryStateCity.Models
{
    public class State
    {
        [Key]
        public int stId { get; set; }
        public string StateName { get; set; }
        [ForeignKey("Country")]
        public int cntId { get; set; }
        public virtual Country Country { get; set; }
    }
}
