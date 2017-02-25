using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        [Display(Name = "Course Title")]
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}