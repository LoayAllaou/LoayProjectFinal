using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllaouFinalPro.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        [Required(ErrorMessage = "Enter Menu Name")]
        public string MenuName { get; set; }
        [Required(ErrorMessage = "Enter Menu Url")]
        public string MenuUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
