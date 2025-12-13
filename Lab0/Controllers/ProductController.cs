using Lab0.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab0.Controllers;

public class ProductController : Controller
{
    static Dictionary<int, Product> _products = new();
    
    public IActionResult Index()
    {
        return View(_products);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Product model)
    {
        if (ModelState.IsValid)
        {
            int id = _products.Keys.Count == 0 ? 1 : _products.Keys.Max() + 1;
            model.Id = id;
            _products.Add(model.Id, model);

            return RedirectToAction("Index");
        }

        return View(model);
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        if (_products.ContainsKey(id))
            return View(_products[id]);

        return NotFound();
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        if (_products.ContainsKey(id))
            return View(_products[id]);

        return NotFound();
    }
    
    [HttpPost]
    public IActionResult Edit(Product model)
    {
        if (ModelState.IsValid)
        {
            _products[model.Id] = model;
            return RedirectToAction("Index");
        }

        return View(model);
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        if (_products.ContainsKey(id))
            return View(_products[id]);

        return NotFound();
    }
    
    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        _products.Remove(id);
        return RedirectToAction("Index");
    }
}