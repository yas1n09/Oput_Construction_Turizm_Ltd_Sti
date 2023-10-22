using System.ComponentModel.DataAnnotations;

namespace Oput.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="E-mail")]
        [Required(ErrorMessage ="E-maili Giriniz")]
        public string Email { get; set; }


        [Display(Name = "Parola")]
        [Required(ErrorMessage = "Parola Giriniz")]
        public string Password { get; set; }
    }
}
