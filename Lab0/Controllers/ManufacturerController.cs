using Microsoft.AspNetCore.Mvc;

namespace Lab0.Controllers;

public class ManufacturerController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}