using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Educational_Institute.Controllers
{
    public class AboutController : Controller
    {
        
        public IActionResult Information()
        {
            return View();
        }

        public IActionResult Mission()
        {
            return View();
        }

        public IActionResult Chancellor_and_Principal_Officers()
        {
            return View();
        }

    }
}