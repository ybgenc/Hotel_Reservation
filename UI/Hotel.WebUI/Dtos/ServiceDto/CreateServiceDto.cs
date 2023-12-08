using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Enter service icon link")]
        public string ServiceIcon { get; set; }


        [Required(ErrorMessage = "Enter service title")]
        [StringLength(100,ErrorMessage = "Title cannot exceed 100 characters")]
        public string Title { get; set; }


        public string Description { get; set; }
    }
}
