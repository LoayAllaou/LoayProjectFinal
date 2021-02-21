using AllaouFinalPro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllaouFinalPro.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public CourseViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            return View (db.Courses.OrderByDescending(x => x.CId).ToList().Take(6));
        }
    }
}
