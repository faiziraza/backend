using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CountryBind.Models
{
    public class Country
    {
        [Key]
        public int C_id { get; set; }
        public string CuntryName { get; set; }
    }
}
