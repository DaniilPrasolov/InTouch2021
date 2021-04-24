using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InTouch2021.Controllers
{
    public class AnketaFormDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
