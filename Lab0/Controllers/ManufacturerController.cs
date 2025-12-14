using Lab0.Models;
using Lab0.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab0.Controllers;

public class ManufacturerController : Controller
{
    private readonly IManufacturerService _service;

    public ManufacturerController(IManufacturerService service)
    {
        _service = service;
    }

    public IActionResult Index() => View(_service.GetAll());

    [HttpGet]
    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(ManufacturerModel manufacturer)
    {
        if (!ModelState.IsValid)
            return View(manufacturer);

        _service.Add(manufacturer);
        return RedirectToAction("Index");
    }
}