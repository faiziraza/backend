using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dal_2.Data_Model
{
   public class State2
    {
        [Key]
        public int stId { get; set; }
        public string StateName { get; set; }
        [ForeignKey("Country2")]
        public int countryId { get; set; }
        public virtual Country2 Country { get; set; }
    }
}
