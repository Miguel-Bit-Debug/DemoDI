using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Controllers
{
    public class MultiplasClassesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
