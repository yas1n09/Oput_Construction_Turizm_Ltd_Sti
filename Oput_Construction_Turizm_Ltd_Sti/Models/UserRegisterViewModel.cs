using System.ComponentModel.DataAnnotations;

namespace Oput.Models
{
    public class UserRegisterViewModel
    {
        //[Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        //public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen E-Mail Giriniz")]
        public string Mail { get; set; }
        
        
        [Required(ErrorMessage = "Lütfen Parola Giriniz")]
        public string Password { get; set; }
        
        
        [Required(ErrorMessage = "Lütfen Parola Tekrarını Giriniz")]
        [Compare("Password",ErrorMessage ="Parolalar Aynı Değil")]
        public string ConfirmPassword { get; set; }
    }
}
