using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcframework2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            TestUtilitys s1 = TestUtilitys.Instance;
            
            if (null == TestUtilitys.Instance)
            {
                // execute in every request

                TestUtilitys.Instance = "test";
            }
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
    }
}