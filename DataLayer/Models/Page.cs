using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataLayer
{
    public class Page
    {
        [Key]
        public int PageID { get; set; }

        [DisplayName("گروه صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int GroupID { get; set; }

        [DisplayName("عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(250)]
        public string Title { get; set; }

        [DisplayName("توضیح کوتاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(400)]
        [DataType(dataType:DataType.MultilineText)]
        public string ShortDescription { get; set; }

        [DisplayName("متن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(dataType: DataType.MultilineText)]
        [AllowHtml]
        public string Text { get; set; }

        [DisplayName("تصویر")]
        public string ImageName { get; set; }

        [DisplayName("اسلایدر")]
        public bool ShowInSlider { get; set; }

        [DisplayName("بازدید")]
        public int Visit { get; set; }

        [DisplayName("تاریخ خبر")]
        [DisplayFormat (DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime CreateDate { get; set; }

        [DisplayName("کلمات کلیدی")]
        [MaxLength(250)]
        public string Tags { get; set; }

        public virtual PageGroup PageGroup { get; set; }
        public List<PageComment> PageComment { get; set; }
        public Page()
        {
            
        }
    }
}
