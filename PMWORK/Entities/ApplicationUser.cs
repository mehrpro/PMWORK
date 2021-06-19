
using System.Collections.Generic;


namespace PMWORK.Entities
{
    /// <summary>
    /// کاربران
    /// </summary>
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            RequestRepairs = new HashSet<RequestRepair>();
            Codings = new HashSet<Coding>();
        }


        //[Required]
        //[MaxLength(250)]
        //public string FullName { get; set; }





        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
        public virtual ICollection<Coding> Codings { get; set; }
    }
}