using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.DataModel
{
    public class Country
    {
        [Key]
        public int cntId { get; set; }
        public string Countryname { get; set; }
    }
}
