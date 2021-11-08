using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstAppASP.Models;

namespace MyFirstAppASP.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.name ="Cesar";
            personal.lastname ="Martinez";
            personal.age=20;
            return View(personal);
        }
    }
}
