using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Name required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "UserName required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail required")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password required")]
        [Compare("Password",ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }

    }
}
