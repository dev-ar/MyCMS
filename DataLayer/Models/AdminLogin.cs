using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AdminLogin
    {
        [Key]
        public int LoginId { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200)]
        [DisplayName("ایمیل")]
        public string Emial { get; set; }   

        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200)]
        [DisplayName("نام کاربری")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200)]
        [DisplayName("رمز عبور")]
        public string Password { get; set; }

    }
}
