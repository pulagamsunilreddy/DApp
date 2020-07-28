using System.ComponentModel.DataAnnotations;

namespace DApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(15, MinimumLength = 7, ErrorMessage = "enter password length between 7 and 15")]
        public string Password { get; set; }
    }
}