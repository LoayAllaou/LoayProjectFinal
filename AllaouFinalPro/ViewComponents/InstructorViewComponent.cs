using AllaouFinalPro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllaouFinalPro.ViewComponents
{
    public class InstructorViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public InstructorViewComponent(AppDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Instructors.OrderByDescending(x => x.InstructorId).ToList());
        }
    }
}
