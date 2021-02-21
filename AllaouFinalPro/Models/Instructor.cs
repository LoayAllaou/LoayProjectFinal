using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllaouFinalPro.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        [Required(ErrorMessage = "Instructor Name")]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; }
        [Required(ErrorMessage = "Instructor Position")]
        [Display(Name = "Instructor Position")]
        public string InstructorPosition { get; set; }
        public string InstructorImg { get; set; }
        public string FbUrl { get; set; }
        public string TwiUrl { get; set; }
        public string InstaUrl { get; set; }
    }
}
