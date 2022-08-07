using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RunnerModel.ModelView
{
   public class EmpModel
    {
        [Key]
        
        public int EmpId { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email is required")]

        //[RegularExpression(@"\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b",ErrorMessage ="email is not")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
                  ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        [Required(ErrorMessage ="mobile number is required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone number is not valid.")]
        public string Mobile { get; set; }
                
       

    }
}
