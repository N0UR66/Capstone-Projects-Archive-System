

using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ProjectType
    {
        [Key]
        public int TypeID { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string TypeNAME { get; set; }

    }
}
