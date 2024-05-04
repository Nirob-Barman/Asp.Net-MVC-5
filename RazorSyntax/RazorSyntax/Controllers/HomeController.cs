using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorSyntax.Models;

namespace RazorSyntax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.myName = "Nirob Barman";
            return View();
        }
        public ActionResult About(string name = null)
        {
            ViewBag.Name = name;
            //var abc = "Name Parameter in About View: " + name;
            Console.WriteLine("Name Parameter in About View: " + name);
            ViewBag.myList = new List<string>()
            {
                "John", "Doe", "kim", "Rock"
            };
            List<ViewBagEmployee> employeeList = new List<ViewBagEmployee>
            {
                new ViewBagEmployee() { Id = 1, Name = "Abul", Email = "abul@gmail.com" },
                new ViewBagEmployee() { Id = 2, Name = "Babul", Email = "babul@gmail.com" },
                new ViewBagEmployee() { Id = 3, Name = "Cabul", Email = "cabul@gmail.com" },
                new ViewBagEmployee() { Id = 4, Name = "Dabul", Email = "dabul@gmail.com" },
            };
            
            ViewData["MyKey"] = "This is a value for from view data";
            ViewData["myList"] = new List<string>(){"John", "Doe", "kim", "Rock"};
            ViewBag.employeeList = employeeList;
            return View();
        }

    }
}