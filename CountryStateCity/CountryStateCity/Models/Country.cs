using System.ComponentModel.DataAnnotations;

namespace CountryStateCity.Models
{
    public class Country
    {
        [Key]
        public int cntId { get; set; }
        public string Countryname { get; set; }
    }
}