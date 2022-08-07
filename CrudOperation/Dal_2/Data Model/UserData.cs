using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dal_2.Data_Model
{
    public class UserData
    {
        [Key]
        public int userId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Country2 { get; set; }
        public string State2 { get; set; }
        public string City2 { get; set; }
    }
}
