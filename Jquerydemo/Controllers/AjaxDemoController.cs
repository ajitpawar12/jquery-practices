using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jquerydemo.Models;

namespace Jquerydemo.Controllers
{
    public class AjaxDemoController : Controller
    {
        // GET: AjaxDemo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
             var person = new Person
                {
                    Name = "ajit",
                    Email = "aj@gmail.com",
                    City = "Pune",
                    Phone = "123",
                    DateTime = DateTime.Now.ToString()
                };
            

            return Json(person);
        }
    }
}