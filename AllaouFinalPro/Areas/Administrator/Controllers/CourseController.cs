using AllaouFinalPro.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace AllaouFinalPro.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public CourseController(AppDbContext context , IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var course = _context.Courses.ToList();
            return View(course);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Instructor"] = new SelectList(_context.Instructors, "InstructorId", "InstructorName", null);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Course course)
        {
            if(ModelState.IsValid)
            {
                //string RootPath = _hostEnvironment.WebRootPath;
                //string path = Path.Combine(RootPath + "/Uploads/Courses/" + FileName);
                //using (var fileStream = new FileStream(path , FileMode.Create))
                //{
                //   await  course.CourseImg.CopyToAsync(fileStream);
                //}
                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;
                        //There is an error here
                        var uploads = Path.Combine(_hostEnvironment.WebRootPath, "Uploads\\Courses");
                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                course.CourseImg = fileName;
                            }

                        }
                    }
                }
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            return View(course);
        }

        [HttpGet]
        public IActionResult Details(Guid Id)
        {
            var course = _context.Courses.Find(Id);
            return View(course);
        }
        [HttpGet]
        public IActionResult Edit(Guid Id)
        {
            ViewData["Instructor"] = new SelectList(_context.Instructors, "InstructorId", "InstructorName", null);
            var course = _context.Courses.Find(Id);
            return View(course);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Course course)
        {
            

            if (ModelState.IsValid)
            {
                if (course.CourseImg == null)
                {
                 //   string cID = course.CId.ToString();
                    var C = _context.Courses.Find(course.CId);
                    course.CourseImg = C.CourseImg;
                }
                else
                {
                    var files = HttpContext.Request.Form.Files;
                    foreach (var Image in files)
                    {
                        if (Image != null && Image.Length > 0)
                        {
                            var file = Image;
                            //There is an error here
                            var uploads = Path.Combine(_hostEnvironment.WebRootPath, "Uploads\\Courses");
                            if (file.Length > 0)
                            {
                                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                    course.CourseImg = fileName;
                                }

                            }
                        }
                    }
                }
               
                _context.Courses.Update(course);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        public IActionResult Delete(Guid id)
        {
            var course = _context.Courses.Find(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }
    }
}
