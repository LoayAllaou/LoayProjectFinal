using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AllaouFinalPro.Models
{
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Slider Id")]
        public Guid SliderId { get; set; }
        [Required(ErrorMessage = "Enter Title")]
        [MaxLength(25)]
        [Display(Name = "Slider Title")]
        public string SliderTitle { get; set; }
        [Required(ErrorMessage = "Enter Description")]
        [MaxLength(35)]
        [Display(Name = "Slider Description")]
        public string SliderDesc { get; set; }
        [Required(ErrorMessage = "Enter Description")]
        [Range(1, 100, ErrorMessage = "Between 1 - 100 ")]
        [Display(Name = "Offer %")]
        public decimal OfferPer { get; set; }
        [Required(ErrorMessage = "Upload Image")]
        public string SliderImg { get; set; }
        public string Location { get; set; }
        public bool IsPublished { get; set; }
    }
}
