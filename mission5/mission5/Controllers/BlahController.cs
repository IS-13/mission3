using Microsoft.AspNetCore.Mvc;
using mission5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission5.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator(CalcModel model)
        {
            return View();
        }

    }
}
