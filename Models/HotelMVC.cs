using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC2019.Models
{
    public class HotelMVC
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int HotelNr { get; set; }
        [Display(Name = "Hotel Name")]
        [Required]
        public String Navn { get; set; }
        
        [Required]
        public String Adresse { get; set; }

    }
}
