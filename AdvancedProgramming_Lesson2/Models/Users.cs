using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Display(Name = "Pseudo")]
        public string Pseudo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Register date")]
        public DateTime RegisterDate { get; set; }
        [Display(Name = "Mail")]
        public string Mail { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
    }
}
