using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dal_2.Data_Model
{
   public class City2
    {
        [Key]
        public int ctId { get; set; }
        public string CityName { get; set; }
        [ForeignKey("State2")]
        public int stateId { get; set; }
        public virtual State2 State { get; set; }
    }
}
