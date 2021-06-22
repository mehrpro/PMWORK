using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.CodingForms.ViewModels
{
   public class CompanyViewModel
    {
        [Display(Name = "شناسه")]
        public int ID { get; set; }
        [Display(Name = "کد")]
        public byte CompnayIndex { get; set; }
        [Display(Name = " گروه یا شرکت")]
        public string CompanyTiltle { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

    }
}
