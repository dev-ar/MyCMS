using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageComment
    {
        [Key]
        public int CommentID { get; set; }

        [DisplayName("خبر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int PageID { get; set; }

        [DisplayName("نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50)]
        public string Name { get; set; }

        [DisplayName("ایمیل")]
        [MaxLength(150)]
        public string Email { get; set; }

        [DisplayName("وبسایت")]
        [MaxLength(200)]
        public string Website { get; set; }

        [DisplayName("نظر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(500)]
        public string Comment { get; set; }

        [DisplayName("تاریخ نظر")]
        public DateTime CreateDate { get; set; }

        public virtual Page Page { get; set; }

        public PageComment()
        {
            
        }
    }
}
