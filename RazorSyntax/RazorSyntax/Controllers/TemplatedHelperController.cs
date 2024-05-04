using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorSyntax.Models;

namespace RazorSyntax.Controllers
{
    public class TemplatedHelperController : Controller
    {
        // GET: TemplatedHelper
        public ActionResult Index()
        {
            TemplateEmployee emp = new TemplateEmployee() {
                ID = 1,
                Name = "Nirob Barman",
                Email = "nirob@gmail.com",
                isOnline = false,
                DateOfBirth = DateTime.Now
            };
            return View(emp);
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(TemplateEmployee emp)
        {

            return View();
        }
    }
}