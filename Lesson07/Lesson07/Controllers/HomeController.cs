using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace lesson07_examples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public IActionResult Index()
        {
            string[] fruits = { "Apple", "Orange", "Pear" };
            return View(fruits);
           
        }

        public string List() {    
            return "List Action Method is not implemented";
        }

        public string Edit() {
            return "Edit Action Method is not implemented";
        }



        //[ChildActionOnly]
        //public ActionResult ChildActionExample() {
        //    string[] myMovies = { "One Flew Over the Cuckoo's Nest", 
        //                            "Schindler's List", 
        //                            "Before Sunrise", 
        //                            "Blue Ruin" };
            
        //    return PartialView("_ChildActionExample", myMovies);
        //}

        public IActionResult NoLayout() {
            return View();
        }

        public IActionResult WithLayout() {
            return View();
        }

        public IActionResult DifferentLocation()
        {
            return View("~/Views/AlternativeViewsFolder/MySpecialView.cshtml");
        }

        public IActionResult Test()
        {
            return View();
        }




    }
}