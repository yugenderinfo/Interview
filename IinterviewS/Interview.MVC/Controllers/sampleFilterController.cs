using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview.MVC.Controllers
{
    public class sampleFilterController : Controller
    {
        // GET: sampleFilter
        public ActionResult Index()
        {
            return View();
        }

        //    [HttpGet]
        //    OutputCache(Duration = 10)] 
        //public string Index2()
        //    {
        //        return  DateTime.Now.ToString("T");

        //    }
        // tempdata

        public ActionResult FirstRequest()
        {
            List<string> TempDataTest = new List<string>();
            TempDataTest.Add("Tejas");
            TempDataTest.Add("Jignesh");
            TempDataTest.Add("Rakesh");
            TempData["EmpName"] = TempDataTest;
            return View();
        }

        //ViewBag
        public ActionResult StudentSummary()
        {
            var student = new Student()
            {
                Name = "Sandeep Singh Shekhawat",
                Age = 24,
                City = "Jaipur"
            };
            ViewBag.Student = student;
            return View();
        }
        public ActionResult ConsecutiveRequest()
        {
            List<string> modelData = TempData["EmpName"] as List<string>;
            TempData.Keep();
            return View(modelData);
        }
        public JsonResult JsonResultTest()
        {
            return Json("Hello My Friend!");
        }



    }

    internal class Student
    {
        public Student()
        {
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}