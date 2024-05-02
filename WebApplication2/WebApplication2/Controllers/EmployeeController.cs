using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "Employee";
        }
        public string EmployeeProfile(int id)
        {
            string profile = string.Empty;
            if(id == 1)
            {
                profile = "Employee 1 profile";
            }
            else if (id == 2)
            {
                profile = "Employee 2 profile";
            }
            else
            {
                profile = "No profile found";
            }
            //return "Profile";
            return profile;
        }


        //public string Address(int id, string department)
        //{
        //    return "id = " + id + " dept = " + department;
        //}

        public string Address(int id, int? code = null)
        {
            if (code == null)
            {
                return "id = " + id;
            }
            else
            {
                return "id = " + id + " dept = " + code;
            }

            //if(id)
            //{
            //    return "id = " + id;
            //}
        }
    }
}