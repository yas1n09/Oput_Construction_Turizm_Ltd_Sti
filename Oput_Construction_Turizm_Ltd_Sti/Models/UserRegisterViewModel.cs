using System.ComponentModel.DataAnnotations;

namespace Oput.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Email Giriniz:")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen Parola Giriniz:")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen Parolayı Tekrar Giriniz:")]
        [Compare("Password",ErrorMessage ="Parolalar Uyumlu değil.")]
        public string ConfirmPassword { get; set; }

    }
}
