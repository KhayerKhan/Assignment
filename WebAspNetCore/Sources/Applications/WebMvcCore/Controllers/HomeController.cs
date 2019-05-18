using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvcCore.Data;
using WebMvcCore.Models;

namespace WebMvcCore.Controllers
{
    public class HomeController : Controller
    {
        private DemoContext _context;
        public HomeController(DemoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
             return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
