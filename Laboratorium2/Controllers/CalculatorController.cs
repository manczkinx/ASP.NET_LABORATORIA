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
                return BadRequest();
            }
            return View(model);
        }