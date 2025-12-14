using Lab0.Models.Services;
using Lab0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab0.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    public IActionResult Index() => View(_service.GetAll());
    
    [HttpGet]
    public IActionResult Create()
    {
        var model = new Product();
        PopulateManufacturers(model);
        return View(model);
    }

    [HttpPost]
    public IActionResult Create(Product model)
    {
        if (!ModelState.IsValid)
        {
            PopulateManufacturers(model);
            return View(model);
        }

        _service.Add(model);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var product = _service.GetById(id);
        if (product == null) return NotFound();

        PopulateManufacturers(product);
        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(Product model)
    {
        if (!ModelState.IsValid)
        {
            PopulateManufacturers(model);
            return View(model);
        }

        _service.Update(model);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        var product = _service.GetById(id);
        return product == null ? NotFound() : View(product);
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var product = _service.GetById(id);
        return product == null ? NotFound() : View(product);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _service.Delete(id);
        return RedirectToAction("Index");
    }

    private void PopulateManufacturers(Product model)
    {
        model.Manufacturers = _service.GetAllManufacturers()
            .Select(m => new SelectListItem
            {
                Value = m.Id.ToString(),
                Text = m.Name
            })
            .ToList();
    }
}
