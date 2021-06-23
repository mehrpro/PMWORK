using System.ComponentModel.DataAnnotations;

namespace PMWORK.CodingForms.ViewModels
{
    public class SubGroupViewModel
    {
        [Display(AutoGenerateField = false)]
        public int ID { get; set; }
        [Display(Name ="کد")]
        public byte SubGroupIndex { get; set; }
        [Display(Name ="عنوان")]
        public string SubGroupTitle { get; set; }
        [Display(Name ="توضیحات")]
        public string Description { get; set; }
    }
}
