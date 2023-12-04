using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DtoLayer.Dtos.RoomDto
{
    public class CreateRoomDto
    {
        [Required(ErrorMessage = "Please enter room number")]
        public int Price { get; set; }

        [Required(ErrorMessage ="Please enter room price")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter room title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the number of beds")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter the number of bath")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
