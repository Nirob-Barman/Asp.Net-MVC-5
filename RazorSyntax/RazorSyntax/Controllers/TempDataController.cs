using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorSyntax.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            TempData["myKey"] = "Data from index metod";
            TempData.Keep("myKey");
            return View();
        }
        public ActionResult Index2()
        {
            Session.Abandon();

            ViewBag.myKey = TempData["myKey"];
            TempData.Keep("myKey");
            //ViewBag.myKey = TempData.Peek("myKey");
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.myKey = TempData["myKey"];
            return View();
        }
    }
}