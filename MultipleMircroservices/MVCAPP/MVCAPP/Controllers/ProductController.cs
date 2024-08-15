using Microsoft.AspNetCore.Mvc;
using MVCAPP.Services;

namespace MVCAPP.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var products = await
           _productService.GetProductsAsync();
            return View(products);
        }
    }
}
