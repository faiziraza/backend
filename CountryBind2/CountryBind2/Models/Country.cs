using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CountryBind2.Models
{
    public class Country
    {
        [Key]
        public int id { get; set; }
        public string Country_Name { get; set; }

    }
}
