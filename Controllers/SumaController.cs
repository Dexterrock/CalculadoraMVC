using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class SumaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String Suma()
        {
            return "Hola";
        }
        public IActionResult Resta()
        {
            return View();
        }

                public IActionResult Multiplicacion()
        {
            return View();
        }

    }
}