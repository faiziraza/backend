using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.DataModel
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
