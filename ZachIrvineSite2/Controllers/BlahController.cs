using Microsoft.AspNetCore.Mvc;
using ZachIrvineSite2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZachIrvineSite2.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalc(GradeCalcClass model)
        {
            return View();
        }
    }
}
