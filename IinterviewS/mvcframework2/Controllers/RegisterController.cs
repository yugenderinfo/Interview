using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace mvcframework2.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

       
        public string getallcategory()
        {
            List<employees> ls = new List<employees>();
            ls.Add(new employees { divName = "divMain", name = "yugender", code = "test", tooltiptext= "test1" });
            ls.Add(new employees { divName = "divmain2", name = "yugender2", code = "test2", tooltiptext = "test2" });
            ls.Add(new employees { divName = "divmain3", name = "yugender3", code = "test3", tooltiptext = "test3" });
            string jsonresult = JsonConvert.SerializeObject(ls);
            return jsonresult;
        }
    }
}