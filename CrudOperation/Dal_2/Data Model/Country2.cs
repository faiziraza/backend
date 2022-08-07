using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dal_2.Data_Model
{
   public class Country2
    {
        [Key]
        public int cntId { get; set; }
        public string CountryName { get; set; }
        
    }
}
