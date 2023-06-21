using System.ComponentModel.DataAnnotations;

namespace MotorShop.Front.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "This is not a valid email!")]
        public string EmailAddress { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "This password is too short!")]
        public string Password { get; set; }
    }
}
