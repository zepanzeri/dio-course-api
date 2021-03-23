using System.ComponentModel.DataAnnotations;

namespace dio_coruse_api.Controllers.Models.Users
{
    public class RegisterViewModelInput
    {
        [Required(ErrorMessage = "Login is required")]
        public string Login { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "E-mail is required")]
        public string Email { get; set; }
    }
}