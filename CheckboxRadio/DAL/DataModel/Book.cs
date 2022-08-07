using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.DataModel
{
   public class Book
    {
        [Key]
        public int id { get; set; }
        public int MinimumAge { get; set; }
        public string Title { get; set; }
        public string Generes { get; set; }
        public string Type { get; set; }
    }
}
