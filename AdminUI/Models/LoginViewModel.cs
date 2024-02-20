using System.ComponentModel.DataAnnotations;

namespace AdminUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="E-posta alanı boş geçilemez")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password alanı boş geçilmez ")]
        public required string Password { get; set; }
    }
}
