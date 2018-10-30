using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LearnerBay.Models;

namespace LearnerBay.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Instructor()
        {
            

            return View();
        }
        public IActionResult InstructorDetail()
        {
            

            return View();
        }

        public IActionResult Features()
        {
            

            return View();
        }
        public IActionResult Price()
        {
            

            return View();
        }
        public IActionResult ErrorPage()
        {
            

            return View();
        }
        public IActionResult GalleryThreeColumn()
        {
            

            return View();
        }
        public IActionResult GalleryFullWidth()
        {
            

            return View();
        }

        public IActionResult Blog()
        {
            

            return View();
        }

        public IActionResult ContactUs()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
