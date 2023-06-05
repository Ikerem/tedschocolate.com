using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace tedschocolateUI.ViewComponents.UserLoginRegisterViewModel
{
    public class UserLoginRegisterViewModel
    {
        [Display(Name = "Kullanıcı adi")]
        [Required(ErrorMessage = "Kullanıcı adı Giriniz..")]
        public string UserName { get; set; }
        [Display(Name = "Şifre ")]
        [Required(ErrorMessage = "Şifreyi Giriniz Giriniz..")]
        public string Password { get; set; }
    }
}
