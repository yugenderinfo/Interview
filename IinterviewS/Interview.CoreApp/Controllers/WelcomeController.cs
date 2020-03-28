using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interview.CoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "John");
            HttpContext.Session.SetInt32("Age", 32);

            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }

      
    }
}