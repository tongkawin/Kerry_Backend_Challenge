using System.ComponentModel.DataAnnotations;

namespace Kerry_Challenge.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Fullname is required")]
        public string? Fullname { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
