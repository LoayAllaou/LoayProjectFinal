using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AllaouFinalPro.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CId { get; set; }
        [Required(ErrorMessage = "Enter Course Name")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Enter Course Desc")]
        public string CourseDesc { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }
        public decimal Price { get; set; }
        public string CourseImg { get; set; }
        public string Venu { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
