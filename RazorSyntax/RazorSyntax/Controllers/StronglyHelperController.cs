using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorSyntax.Models;

namespace RazorSyntax.Controllers
{
    public class StronglyHelperController : Controller
    {
        // GET: StroglyHelper
        public ActionResult Index()
        {
            Employee emp = new Employee() {
                ID = 2,
                Name = "Nirob Barman",
                Address = "Bandar",
                isEmplyoee = true
            };
            return View(emp);
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            Console.WriteLine(emp.Address);
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}