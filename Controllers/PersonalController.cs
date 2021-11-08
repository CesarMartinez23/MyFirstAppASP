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
            personal.profession = "Student";
            personal.experience = "1 Year";
            personal.phone = "+503 7470-8027";
            personal.email = "SMIS055621@UGB.EDU.SV";
            personal.location = "Santa Rosa de Lima, La Union, El Salvador, Centroamerica.";
            personal.name ="Cesar";
            personal.lastname ="Martinez";
            personal.age=20;
            return View(personal);
        }
    }
}
