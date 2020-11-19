using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspNetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspNetApp.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository repository;

        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Products);

        public ViewResult Edit(int productId) =>
            View(repository.Products
                .FirstOrDefault(p => p.ProductID == productId));

        [HttpPost]
        public IActionResult Save(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"Zapisano {product.Name}.";
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", product);
            }

        }
        public ViewResult Create() => View("Edit", new Product());

        [HttpPost]
        public IActionResult Delate(int productId)
        {
            Product delatedProduct = repository.DelateProduct(productId);
            if (delatedProduct != null)
            {
                TempData["message"] = $"Usinięto {delatedProduct.Name}.";
            }
            return RedirectToAction("Index");
        }
    }
}
