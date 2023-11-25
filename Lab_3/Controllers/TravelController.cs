using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers;

public class TravelController : Controller
{
    [HttpGet]

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ViewResult Create(Travel travel)
    {
        if (ModelState.IsValid)
        {

        }
        else
        {
            return View();
        }
    }
}