using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Devices
    {
        public int ID { get; set; }
        [Display(Name = "Type")]
        public string Type { get; set; }
        [Display(Name = "Producer")]
        public string Producer { get; set; }
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Display(Name = "Reliable User")]
        public string ReliableUser { get; set; }
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "Ticket")]
        public int Ticket { get; set; }
    }
}
