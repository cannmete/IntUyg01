using IntUyg01.Models;
using IntUyg01.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IntUyg01.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _ProductRepository; 

        public ProductController(ProductRepository productRepository)
        {
            _ProductRepository = productRepository;
        }

        public IActionResult Index1()
        {
            var products = _ProductRepository.GetList();
            return View(products);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
