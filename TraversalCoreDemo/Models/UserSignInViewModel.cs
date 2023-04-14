using System.ComponentModel.DataAnnotations;

namespace TraversalCoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz.")]
        public string Password { get; set; }
    }
}
