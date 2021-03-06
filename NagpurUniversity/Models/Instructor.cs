using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NagpurUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FName { get; set; }

        [Required]
        [Column("MName")]
        [Display(Name = "Middle Name")]
        [StringLength(50)]
        public string MName { get; set; }

        [Required]
        [Column("LName")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FName + ", " + MName + ", " + LName; }
        }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}