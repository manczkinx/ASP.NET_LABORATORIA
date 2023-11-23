using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorium2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       public IActiopnResult Result([FromForm] Calculaotr model)
        {
            if (!model.isValid())
            {
                return View("Error");
            }
            return View(model);
        }

        public IActionResult Form()
        {
            return View();
        }