using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Educational_Institute.Controllers
{
    public class AcademicsController : Controller
    {
        public IActionResult Courses_and_Tuition_Fees()
        {
            return View();
        }

        public IActionResult Academic_Calender()
        {
            return View();
        }
    }
}