using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 8, ErrorMessage="You must specify a password between 8 and 25 characters")]
        public string Password { get; set; }
    }
}