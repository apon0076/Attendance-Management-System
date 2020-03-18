using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Educational_Institute.Controllers
{
    public class Sign_UpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}