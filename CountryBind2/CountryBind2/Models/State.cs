using System.ComponentModel.DataAnnotations;

namespace CountryBind2.Models
{
    public class State
    {
        [Key]
        public int state_id { get; set; }
        public string StateName { get; set; }


    }
}