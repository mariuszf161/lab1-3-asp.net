using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspNetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspNetApp.Controllers
{
    public class ProductController : Controller
    {
        public readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ViewResult ListAll() => View(productRepository.Products);
        public ViewResult List(string category) => View(productRepository.Products.Where(p => p.Category == category));
    }
}
