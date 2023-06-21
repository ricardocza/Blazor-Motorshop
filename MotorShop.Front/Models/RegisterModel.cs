using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MotorShop.Front.Models
{
    public class RegisterModel
    {
        public int Id { get; set; }
        
        [Required]        
        public string FirstName { get; set; }
        
        [Required]        
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
