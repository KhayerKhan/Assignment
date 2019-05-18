using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvcCore.Data;
using WebMvcCore.Models;

namespace WebMvcCore.Controllers
{
    public class StudentController : Controller
    {
        private DemoContext _context;
        public StudentController(DemoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student oStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Student.Add(oStudent);
                int successCount = _context.SaveChanges();
                bool IsSaved = successCount>0;
                if (IsSaved)
                {
                    ViewBag.msg = "Saved Successfully";
                }
            }
            return  View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Save(Student oStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Student.Add(oStudent);
                int successCount = _context.SaveChanges();
                bool IsSaved = successCount > 0;
                if (IsSaved)
                {
                    ViewBag.msg = "Saved Successfully";
                }
            }
            return View();
        }

    }
}