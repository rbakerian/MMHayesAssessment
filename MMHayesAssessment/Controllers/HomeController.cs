using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MMHayesAssessment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult EmployeeAccess(
            string employee_name, 
            string employee_number,
            string employee_phone,
            string employee_address,
            string employee_city,
            string employee_state,
            string employee_zipcode,
            string employee_status)
        {
            return Json(employee_name);
        }

    }
}