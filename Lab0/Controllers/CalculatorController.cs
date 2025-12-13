using Lab0.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab0.Controllers;

public class CalculatorController : Controller
{
    [HttpPost]
    public IActionResult Result([FromForm] Calculator model)
    {
        if (!model.IsValid())
        {
            return View("Error");
        }

        return View(model);
    }
    public IActionResult Form()
    {
        return View();
    }
}