using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllaouFinalPro.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [Required(ErrorMessage = "Client Name")]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }
        [Required(ErrorMessage = "Client Position")]
        [Display(Name = "Client Position")]
        public string ClientPosition { get; set; }
        [Required(ErrorMessage = "Client Image")]
        [Display(Name = "Client Image")]
        public string ClientImage { get; set; }
        [Required(ErrorMessage = "Client Comment")]
        [Display(Name = "Client Comment")]
        public string ClientComment { get; set; }

    }
}
