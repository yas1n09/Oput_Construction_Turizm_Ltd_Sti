using System.ComponentModel.DataAnnotations;

namespace Oput.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adını giriniz...!")]
        public string Email { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi giriniz...!")]
        public string Password { get; set; }
    }
}
