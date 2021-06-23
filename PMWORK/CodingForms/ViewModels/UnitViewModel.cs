using System.ComponentModel.DataAnnotations;

namespace PMWORK.CodingForms.ViewModels
{
    public class UnitViewModel
    {
        [Display(AutoGenerateField =false)]
        public int ID { get; set; }
        [Display(Name ="واحد سنجش")]
        public string Unit { get; set; }
        [Display(Name ="توضیحات")]
        public string Description { get; set; }
    }
}
