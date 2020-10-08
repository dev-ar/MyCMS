using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageGroup
    {
        [Key]
        public int GroupID { get; set; }

        [DisplayName("عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Title { get; set; }


        public virtual List<Page> Page { get; set; }
        public PageGroup()
        {
            
        }
    }
}
