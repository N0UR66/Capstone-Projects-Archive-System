using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CapstoneProjects.Models
{
    public class Department
    {
        [Key]
        public int DepID { get; set; }

        [Required]
        [Display(Name = "Department Name")]
        public string DepNAME { get; set; }

    }
}
