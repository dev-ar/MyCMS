using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200)]
        [DisplayName("نام کاربری")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200)]
        [DisplayName("رمز عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("مرا به خاطر بسپار!")]
        public bool RememberMe { get; set; }

    }
}
