using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllaouFinalPro.Areas.Administrator.Controllers
{
    public class CPanelController : Controller
    {
        [Area("Administrator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
