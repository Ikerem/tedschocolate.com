using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace tedschocolateUI.ViewComponents.UserRegisterViewModel
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Adınızı Girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadınızı Girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullancı Adınızı  Girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifrenizi Girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifreyi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Şifre Aynı Değil")]
        public string ConfirmPasword { get; set; }
        [Required(ErrorMessage = "Mail Girin")]
        public string Mail { get; set; }
    }
}
