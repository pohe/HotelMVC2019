using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC2019.Models
{
    public class RoomMVC
    {
        [Key]
        public int RoomMVCID { get; set; }

        public int HotelMVCID { get; set; }
        
        [Required]
        public int RoomNr { get; set; }
        public char Types { get; set; }
        public double Pris { get; set; }

        [ForeignKey("HotelMVCID")]
        public HotelMVC InHotel { get; set; }


    }
}
