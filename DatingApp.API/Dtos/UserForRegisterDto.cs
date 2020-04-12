using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage="Passwrord neeeds to have at least 6 characters and not more than 20!")]
        public string Password { get; set; }
    }
}