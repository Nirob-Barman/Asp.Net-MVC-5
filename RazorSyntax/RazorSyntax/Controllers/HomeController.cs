﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorSyntax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About(string name = null)
        {
            ViewBag.Name = name;
            //var abc = "Name Parameter in About View: " + name;
            Console.WriteLine("Name Parameter in About View: " + name);
            return View();
        }
    }
}