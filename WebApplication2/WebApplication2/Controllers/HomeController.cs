using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string index()
        {
            return "hello from web";
        }

        public string Name()
        {
            return "My name is Nirob Barman";
        }
    }
}